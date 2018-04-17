namespace common.sendConfig
{
    partial class SendService
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
            this.btnSearService = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearService
            // 
            this.btnSearService.Location = new System.Drawing.Point(112, 12);
            this.btnSearService.Name = "btnSearService";
            this.btnSearService.Size = new System.Drawing.Size(75, 23);
            this.btnSearService.TabIndex = 0;
            this.btnSearService.Text = "启动服务";
            this.btnSearService.UseVisualStyleBackColor = true;
            this.btnSearService.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(3, 41);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(288, 43);
            this.textBoxOutput.TabIndex = 1;
            // 
            // SendService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 87);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.btnSearService);
            this.Name = "SendService";
            this.Text = "启动服务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearService;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}