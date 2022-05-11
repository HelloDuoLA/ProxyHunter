namespace ProxyHunter
{
    partial class FormVerify
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.VerifyURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(467, 14);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(73, 25);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "开始验证";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(467, 76);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(73, 25);
            this.btnCancle.TabIndex = 27;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // VerifyURL
            // 
            this.VerifyURL.Location = new System.Drawing.Point(157, 14);
            this.VerifyURL.Name = "VerifyURL";
            this.VerifyURL.Size = new System.Drawing.Size(242, 23);
            this.VerifyURL.TabIndex = 30;
            this.VerifyURL.Text = "http://";
            this.VerifyURL.TextChanged += new System.EventHandler(this.VerifyURL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "请输入验证代理目标URL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerifyURL);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancle);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormVerify";
            this.Text = "验证代理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnConfirm;
        private Button btnCancle;
        private Label label1;
        public TextBox VerifyURL;
    }
}