namespace ProxyHunter
{
    partial class FormSearch
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.tp_c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.Location = new System.Drawing.Point(2, 419);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(94, 29);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(102, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.Location = new System.Drawing.Point(202, 419);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
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
            this.tp_c3});
            this.dgvMessage.Location = new System.Drawing.Point(2, 2);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.RowHeadersVisible = false;
            this.dgvMessage.RowHeadersWidth = 51;
            this.dgvMessage.RowTemplate.Height = 29;
            this.dgvMessage.Size = new System.Drawing.Size(796, 416);
            this.dgvMessage.TabIndex = 17;
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
            this.tp_c3.HeaderText = "是否添加";
            this.tp_c3.MinimumWidth = 6;
            this.tp_c3.Name = "tp_c3";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMessage);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAll);
            this.Name = "FormSearch";
            this.Text = "搜索结果";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAll;
        private Button btnAdd;
        private Button btnConfirm;
        private DataGridView dgvMessage;
        private DataGridViewTextBoxColumn tp_c1;
        private DataGridViewTextBoxColumn tp_c2;
        private DataGridViewTextBoxColumn tp_c3;
    }
}