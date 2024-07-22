using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageInt16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Convert.Enabled = false;
            NowPos.Text = "이미지 대기 중...";
            SelectedImgSize.Text = "이미지를 선택해주세요";
            Style.SelectedIndex = 1;
            TableType.SelectedIndex = 0;
            Bitmap img = null;
            Upload.Click += (_, __) =>
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "이미지 파일 (.bmp .jpg .png)|*.bmp;*.jpg;*.png";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Preview.SizeMode = Style.SelectedIndex == 0 ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Zoom;
                        Size size = new Size(64, 64);
                        if (Style.SelectedIndex == 0)
                            size = new Size(64, 32);
                        else if (Style.SelectedIndex == 1)
                            size = new Size(32, 32);
                        Image original = Image.FromFile(dialog.FileName);
                        img = new Bitmap(original, size);
                        if (Style.SelectedIndex == 2)
                        {
                            img = img.Clone(new Rectangle(0, size.Height / 4, size.Width, size.Height / 2), original.PixelFormat);
                            Preview.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        Preview.Image = img;
                        SelectedImgSize.Text = $"{img.Width}*{img.Height} | {Path.GetFileName(dialog.FileName)}";
                        NowPos.Text = "\"변환\" 버튼을 누르세요!";
                        Convert.Enabled = true;
                    }
                }
            };
            Convert.Click += (_, __) =>
            {
                Convert.Enabled = false;
                Style.Enabled = false;
                Copy.Enabled = false;
                Upload.Enabled = false;
                Cursor = Cursors.WaitCursor;
                Task.Run(() =>
                {
                    List<string> strings = new List<string>();
                    if(TableType.SelectedIndex == 1)
                        strings.Add("{");
                    else if (TableType.SelectedIndex == 2)
                        strings.Add("[");
                    else if (TableType.SelectedIndex == 3)
                        strings.Add("(");
                    for (int y = 0; y < img.Height; y++)
                    {
                        for (int x = 0; x < img.Width; x++)
                        {
                            NowPos.Text = $"{x}*{y} 변환 중";
                            Color color = img.GetPixel(x, y);
                            int r = color.R >> 3;
                            int g = color.G >> 2;
                            int b = color.B >> 3;
                            int rgb565 = (r << 11) + (g << 5) + b;
                            string str = $"0x{rgb565.ToString("X")}";
                            if (x != 63 || y != 31) str += ", ";
                            strings.Add(str);
                        }
                        if(y+1!= img.Height)
                            strings.Add("\n");
                        else
                        {
                            if (TableType.SelectedIndex == 1)
                                strings.Add("}");
                            else if (TableType.SelectedIndex == 2)
                                strings.Add("]");
                            else if (TableType.SelectedIndex == 3)
                                strings.Add(")");
                        }
                        Result.Text = String.Join("", strings.ToArray());
                    }
                    NowPos.Text = $"{img.Width}*{img.Height} 변환 성공!";
                    Style.Enabled = true;
                    Copy.Enabled = true;
                    Upload.Enabled = true;
                    Cursor = Cursors.Default;
                });
            };
            Copy.Click += (_, __) =>
            {
                Result.SelectAll();
                Result.Copy();
            };
        }
    }
}
