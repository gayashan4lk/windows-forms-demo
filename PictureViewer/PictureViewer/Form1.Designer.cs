namespace PictureViewer
{
    partial class frmPictureViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picbxMain = new System.Windows.Forms.PictureBox();
            this.cbStretch = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tblLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxMain)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPanel1
            // 
            this.tblLayoutPanel1.ColumnCount = 2;
            this.tblLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblLayoutPanel1.Controls.Add(this.picbxMain, 0, 0);
            this.tblLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tblLayoutPanel1.Controls.Add(this.cbStretch, 0, 1);
            this.tblLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanel1.Name = "tblLayoutPanel1";
            this.tblLayoutPanel1.RowCount = 2;
            this.tblLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPanel1.Size = new System.Drawing.Size(626, 385);
            this.tblLayoutPanel1.TabIndex = 0;
            // 
            // picbxMain
            // 
            this.picbxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblLayoutPanel1.SetColumnSpan(this.picbxMain, 2);
            this.picbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbxMain.Location = new System.Drawing.Point(3, 3);
            this.picbxMain.Name = "picbxMain";
            this.picbxMain.Size = new System.Drawing.Size(620, 340);
            this.picbxMain.TabIndex = 0;
            this.picbxMain.TabStop = false;
            // 
            // cbStretch
            // 
            this.cbStretch.AutoSize = true;
            this.cbStretch.Location = new System.Drawing.Point(3, 349);
            this.cbStretch.Name = "cbStretch";
            this.cbStretch.Size = new System.Drawing.Size(60, 17);
            this.cbStretch.TabIndex = 1;
            this.cbStretch.Text = "Stretch";
            this.cbStretch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnShow);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnBackground);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(96, 349);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Location = new System.Drawing.Point(436, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(88, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show a picture";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(336, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear the picture";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBackground
            // 
            this.btnBackground.AutoSize = true;
            this.btnBackground.Location = new System.Drawing.Point(193, 3);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(137, 23);
            this.btnBackground.TabIndex = 2;
            this.btnBackground.Text = "Set the background color";
            this.btnBackground.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(112, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a image file";
            // 
            // frmPictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 385);
            this.Controls.Add(this.tblLayoutPanel1);
            this.Name = "frmPictureViewer";
            this.Text = "Picture Viewer";
            this.tblLayoutPanel1.ResumeLayout(false);
            this.tblLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxMain)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanel1;
        private System.Windows.Forms.PictureBox picbxMain;
        private System.Windows.Forms.CheckBox cbStretch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

