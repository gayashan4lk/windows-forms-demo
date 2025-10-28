namespace HelloWorld
{
    partial class Form1
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.grpboxHelloWorld = new System.Windows.Forms.GroupBox();
            this.grpboxHelloWorld.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(56, 54);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(35, 29);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(116, 13);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "Please click this button";
            // 
            // grpboxHelloWorld
            // 
            this.grpboxHelloWorld.Controls.Add(this.btnClickThis);
            this.grpboxHelloWorld.Controls.Add(this.lblHelloWorld);
            this.grpboxHelloWorld.Location = new System.Drawing.Point(27, 23);
            this.grpboxHelloWorld.Name = "grpboxHelloWorld";
            this.grpboxHelloWorld.Size = new System.Drawing.Size(200, 100);
            this.grpboxHelloWorld.TabIndex = 2;
            this.grpboxHelloWorld.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpboxHelloWorld.ResumeLayout(false);
            this.grpboxHelloWorld.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.GroupBox grpboxHelloWorld;
    }
}

