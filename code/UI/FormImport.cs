using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ProxyHunter
{
    public partial class FormImport : Form
    {
        public FormImport()
        {
            InitializeComponent();
        }

        private void FormImport_Load(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要取消吗？", "取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSelectPath1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\Users\pc\Desktop",//设置文件打开初始目录为桌面
                Title = "选择代理信息文件",
                Filter = "Files(*.txt)|*.txt",
                RestoreDirectory = true
            };
            string line;
            string fileName = "";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //将选中的文件中的信息传递给待导入代理信息中。
                fileName = dialog.FileName;
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                while ((line = file.ReadLine()) != null)
                {
                    string proxyIP = line.Split(' ')[0];
                    string proxyPort = line.Split(' ')[1];
                    string proxyStatus = line.Split(' ')[2];
                    string proxyCT = line.Split(' ')[3];
                    string proxyVT = line.Split(' ')[4];
                    string proxyComments = line.Split(' ')[5];
                    dgvMessage.Rows.Add(proxyIP, proxyPort, proxyStatus, proxyCT, proxyVT, proxyComments);
                }

            }

        }
    }
}
