namespace Encode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.textBoxEnString = new System.Windows.Forms.TextBox();
            this.buttonEn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(12, 12);
            this.textBoxString.Multiline = true;
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(776, 199);
            this.textBoxString.TabIndex = 0;
            // 
            // textBoxEnString
            // 
            this.textBoxEnString.Location = new System.Drawing.Point(12, 299);
            this.textBoxEnString.Multiline = true;
            this.textBoxEnString.Name = "textBoxEnString";
            this.textBoxEnString.Size = new System.Drawing.Size(776, 199);
            this.textBoxEnString.TabIndex = 1;
            // 
            // buttonEn
            // 
            this.buttonEn.Location = new System.Drawing.Point(12, 231);
            this.buttonEn.Name = "buttonEn";
            this.buttonEn.Size = new System.Drawing.Size(776, 50);
            this.buttonEn.TabIndex = 2;
            this.buttonEn.Text = "EnCode";
            this.buttonEn.UseVisualStyleBackColor = true;
            this.buttonEn.Click += new System.EventHandler(this.buttonEn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.buttonEn);
            this.Controls.Add(this.textBoxEnString);
            this.Controls.Add(this.textBoxString);
            this.Name = "Form1";
            this.Text = "EnCode for RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.TextBox textBoxEnString;
        private System.Windows.Forms.Button buttonEn;
    }
}

