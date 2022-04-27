using static System.Windows.Forms.DataFormats;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProxyHunter
{
    public partial class FormMain : Form
    {
        public static string? proxyIP;
        public static string? proxyPort;
        public static string? proxyStatus;
        public static string? proxyCT;
        public static string? proxyVT;
        public static string? proxyComments;
        

        public FormMain()     
        {
            InitializeComponent();
            //设置控件选中选中的模式
            //单击单元格或行标题能够选中整行
            this.dgvProxyMessage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //不容许用户调整列的排列顺序
            this.dgvProxyMessage.AllowUserToOrderColumns = false;
            //不容许用户调整列的大小
            this.dgvProxyMessage.AllowUserToResizeColumns = true;
            //不容许用户调整行的大小
            this.dgvProxyMessage.AllowUserToResizeRows = true;


            DirectoryInfo configDir = new DirectoryInfo(Application.StartupPath).Parent.Parent.Parent;
            string[] proxyMessage = File.ReadAllLines(configDir + @"\config\proxyInitial.txt");
            for (int i = 0; i < proxyMessage.Length; i++)
            {
                string[] strArray = proxyMessage[i].Split(new char[]{' '});
                proxyIP = strArray[0];
                proxyPort = strArray[1];
                proxyStatus = strArray[2]; 
                proxyCT = strArray[3];
                proxyVT = strArray[4];
                proxyComments = strArray[5];
                dgvProxyMessage.Rows.Add(proxyIP, proxyPort, proxyStatus, proxyCT, proxyVT,proxyComments);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            FormSearch form = new FormSearch();
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.ShowDialog();
            if (form.dgvAddMessage.Rows.Count > 0)
            {
                for (int i = 0; i < form.dgvAddMessage.Rows.Count; i++)
                {
                    proxyIP = form.dgvAddMessage.Rows[i].Cells["proxy_ip"].Value?.ToString();
                    proxyPort = form.dgvAddMessage.Rows[i].Cells["proxy_port"].Value?.ToString();
                    proxyStatus = "未验证";
                    proxyCT = DateTime.Now.ToString();
                    proxyVT = "/";
                    proxyComments = "/";
                    dgvProxyMessage.Rows.Add(proxyIP,proxyPort,proxyStatus,proxyCT,proxyVT,proxyComments);

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除吗？", "删除代理", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow proxyMessageRow in dgvProxyMessage.SelectedRows) 
                {
                    dgvProxyMessage.Rows.Remove(proxyMessageRow);
                }

            }
        }

        
        private void btnImport_Click(object sender, EventArgs e)
        {
            FormImport form = new FormImport();
            form.ShowDialog();
            if (form.dgvMessage.Rows.Count > 0)
            {
                for (int i = 0; i < form.dgvMessage.Rows.Count; i++)
                {
                    proxyIP = form.dgvMessage.Rows[i].Cells["tp_c1"].Value?.ToString();
                    proxyPort = form.dgvMessage.Rows[i].Cells["tp_c2"].Value?.ToString();
                    proxyStatus = form.dgvMessage.Rows[i].Cells["tp_c3"].Value?.ToString();
                    proxyCT = form.dgvMessage.Rows[i].Cells["tp_c4"].Value?.ToString();
                    proxyVT = form.dgvMessage.Rows[i].Cells["tp_c5"].Value?.ToString();
                    proxyComments = form.dgvMessage.Rows[i].Cells["tp_c6"].Value?.ToString();
                    dgvProxyMessage.Rows.Add(proxyIP, proxyPort, proxyStatus, proxyCT, proxyVT, proxyComments);

                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FormExport form = new FormExport();
            form.ShowDialog();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            FormVerify form = new FormVerify();
            form.ShowDialog();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBox_Click(object sender, EventArgs e)
        {

        }

        private void btnProxyBox_Click(object sender, EventArgs e)
        {

        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSet_Windows_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedIndex = 0;
        }

        private void tsmiManageTap_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedIndex = 1;
        }

        private void tsmiSetTap_Click(object sender, EventArgs e)
        {
            tctlMain.SelectedIndex = 2;
        }
     
    }
}