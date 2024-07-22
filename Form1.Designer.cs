namespace ImageInt16
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Upload = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.PictureBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SelectedImgSize = new System.Windows.Forms.Label();
            this.NowPos = new System.Windows.Forms.Label();
            this.Copy = new System.Windows.Forms.Button();
            this.Style = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Upload.Font = new System.Drawing.Font("굴림", 10F);
            this.Upload.Location = new System.Drawing.Point(622, 398);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(177, 32);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "업로드";
            this.Upload.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview.Location = new System.Drawing.Point(3, 17);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(316, 115);
            this.Preview.TabIndex = 1;
            this.Preview.TabStop = false;
            // 
            // Convert
            // 
            this.Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Convert.Font = new System.Drawing.Font("굴림", 10F);
            this.Convert.Location = new System.Drawing.Point(477, 398);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(139, 32);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "변환";
            this.Convert.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.Location = new System.Drawing.Point(12, 12);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(459, 353);
            this.Result.TabIndex = 3;
            // 
            // SelectedImgSize
            // 
            this.SelectedImgSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedImgSize.Location = new System.Drawing.Point(477, 12);
            this.SelectedImgSize.Name = "SelectedImgSize";
            this.SelectedImgSize.Size = new System.Drawing.Size(322, 215);
            this.SelectedImgSize.TabIndex = 4;
            this.SelectedImgSize.Text = "label1";
            // 
            // NowPos
            // 
            this.NowPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NowPos.Location = new System.Drawing.Point(12, 371);
            this.NowPos.Name = "NowPos";
            this.NowPos.Size = new System.Drawing.Size(499, 21);
            this.NowPos.TabIndex = 5;
            this.NowPos.Text = "label2";
            this.NowPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Copy
            // 
            this.Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Copy.Font = new System.Drawing.Font("굴림", 10F);
            this.Copy.Location = new System.Drawing.Point(12, 398);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(91, 32);
            this.Copy.TabIndex = 6;
            this.Copy.Text = "전체 복사";
            this.Copy.UseVisualStyleBackColor = true;
            // 
            // Style
            // 
            this.Style.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Style.Font = new System.Drawing.Font("굴림", 10F);
            this.Style.FormattingEnabled = true;
            this.Style.Items.AddRange(new object[] {
            "이미지 늘리기",
            "이미지 세로로 맞추기",
            "이미지 가로로 맞추기"});
            this.Style.Location = new System.Drawing.Point(622, 371);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(177, 21);
            this.Style.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Preview);
            this.groupBox1.Location = new System.Drawing.Point(477, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "미리보기";
            // 
            // TableType
            // 
            this.TableType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableType.Font = new System.Drawing.Font("굴림", 10F);
            this.TableType.FormattingEnabled = true;
            this.TableType.Items.AddRange(new object[] {
            "없음",
            "{ ~ }",
            "[ ~ ]",
            "( ~ )"});
            this.TableType.Location = new System.Drawing.Point(477, 371);
            this.TableType.Name = "TableType";
            this.TableType.Size = new System.Drawing.Size(139, 21);
            this.TableType.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 442);
            this.Controls.Add(this.TableType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Style);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.NowPos);
            this.Controls.Add(this.SelectedImgSize);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Upload);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image To Int16";
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label SelectedImgSize;
        private System.Windows.Forms.Label NowPos;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.ComboBox Style;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TableType;
    }
}

