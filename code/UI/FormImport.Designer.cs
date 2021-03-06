namespace ProxyHunter
{
    partial class FormImport
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
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.tp_c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSelectPath1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.Location = new System.Drawing.Point(103, 412);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancle.Location = new System.Drawing.Point(203, 412);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(94, 29);
            this.btnCancle.TabIndex = 23;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // dgvMessage
            // 
            this.dgvMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tp_c1,
            this.tp_c2,
            this.tp_c3,
            this.tp_c4,
            this.tp_c5,
            this.tp_c6});
            this.dgvMessage.Location = new System.Drawing.Point(3, 4);
            this.dgvMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.RowHeadersVisible = false;
            this.dgvMessage.RowHeadersWidth = 51;
            this.dgvMessage.RowTemplate.Height = 29;
            this.dgvMessage.Size = new System.Drawing.Size(796, 400);
            this.dgvMessage.TabIndex = 22;
            // 
            // tp_c1
            // 
            this.tp_c1.FillWeight = 200F;
            this.tp_c1.HeaderText = "服务器地址";
            this.tp_c1.MinimumWidth = 6;
            this.tp_c1.Name = "tp_c1";
            // 
            // tp_c2
            // 
            this.tp_c2.FillWeight = 80F;
            this.tp_c2.HeaderText = "端口";
            this.tp_c2.MinimumWidth = 6;
            this.tp_c2.Name = "tp_c2";
            // 
            // tp_c3
            // 
            this.tp_c3.FillWeight = 80F;
            this.tp_c3.HeaderText = "状态";
            this.tp_c3.MinimumWidth = 6;
            this.tp_c3.Name = "tp_c3";
            // 
            // tp_c4
            // 
            this.tp_c4.FillWeight = 200F;
            this.tp_c4.HeaderText = "添加时间";
            this.tp_c4.MinimumWidth = 6;
            this.tp_c4.Name = "tp_c4";
            // 
            // tp_c5
            // 
            this.tp_c5.FillWeight = 200F;
            this.tp_c5.HeaderText = "验证时间";
            this.tp_c5.MinimumWidth = 6;
            this.tp_c5.Name = "tp_c5";
            // 
            // tp_c6
            // 
            this.tp_c6.HeaderText = "备注";
            this.tp_c6.MinimumWidth = 6;
            this.tp_c6.Name = "tp_c6";
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.Location = new System.Drawing.Point(3, 412);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(94, 29);
            this.btnAll.TabIndex = 25;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSelectPath1
            // 
            this.btnSelectPath1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectPath1.Location = new System.Drawing.Point(304, 412);
            this.btnSelectPath1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectPath1.Name = "btnSelectPath1";
            this.btnSelectPath1.Size = new System.Drawing.Size(125, 29);
            this.btnSelectPath1.TabIndex = 26;
            this.btnSelectPath1.Text = "选择导入路径";
            this.btnSelectPath1.UseVisualStyleBackColor = true;
            this.btnSelectPath1.Click += new System.EventHandler(this.btnSelectPath1_Click);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnSelectPath1);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.dgvMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormImport";
            this.Text = "导入代理";
            this.Load += new System.EventHandler(this.FormImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConfirm;
        private Button btnCancle;
        private Button btnAll;
        private Button btnSelectPath1;
        public DataGridView dgvMessage;
        private DataGridViewTextBoxColumn tp_c1;
        private DataGridViewTextBoxColumn tp_c2;
        private DataGridViewTextBoxColumn tp_c3;
        private DataGridViewTextBoxColumn tp_c4;
        private DataGridViewTextBoxColumn tp_c5;
        private DataGridViewTextBoxColumn tp_c6;
    }
}