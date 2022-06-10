namespace ProxyHunter
{
    partial class FormAdd
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
            this.dgvAddMessage = new System.Windows.Forms.DataGridView();
            this.proxy_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxy_port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddMessage
            // 
            this.dgvAddMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddMessage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAddMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proxy_ip,
            this.proxy_port});
            this.dgvAddMessage.Location = new System.Drawing.Point(3, 68);
            this.dgvAddMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAddMessage.Name = "dgvAddMessage";
            this.dgvAddMessage.RowHeadersVisible = false;
            this.dgvAddMessage.RowHeadersWidth = 51;
            this.dgvAddMessage.RowTemplate.Height = 29;
            this.dgvAddMessage.Size = new System.Drawing.Size(796, 342);
            this.dgvAddMessage.TabIndex = 18;
            // 
            // proxy_ip
            // 
            this.proxy_ip.FillWeight = 200F;
            this.proxy_ip.HeaderText = "选择IP地址";
            this.proxy_ip.MinimumWidth = 6;
            this.proxy_ip.Name = "proxy_ip";
            // 
            // proxy_port
            // 
            this.proxy_port.FillWeight = 80F;
            this.proxy_port.HeaderText = "选择端口";
            this.proxy_port.MinimumWidth = 6;
            this.proxy_port.Name = "proxy_port";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.Location = new System.Drawing.Point(3, 418);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancle.Location = new System.Drawing.Point(102, 418);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(94, 29);
            this.btnCancle.TabIndex = 20;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(3, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 20);
            this.lbl1.TabIndex = 22;
            this.lbl1.Text = "ip地址";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(564, 9);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(39, 20);
            this.lbl2.TabIndex = 23;
            this.lbl2.Text = "端口";
            // 
            // IPAddress
            // 
            this.IPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAddress.Location = new System.Drawing.Point(3, 33);
            this.IPAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(555, 27);
            this.IPAddress.TabIndex = 24;
            // 
            // port
            // 
            this.port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.port.Location = new System.Drawing.Point(564, 33);
            this.port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(124, 27);
            this.port.TabIndex = 25;
            this.port.Text = " ";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(694, 32);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.port);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.dgvAddMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdd";
            this.Text = "增加代理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnConfirm;
        private Button btnCancle;
        private Label lbl1;
        private Label lbl2;
        private TextBox IPAddress;
        private TextBox port;
        private Button btnAdd;
        public DataGridViewTextBoxColumn proxy_ip;
        public DataGridViewTextBoxColumn proxy_port;
        public DataGridView dgvAddMessage;
    }
}