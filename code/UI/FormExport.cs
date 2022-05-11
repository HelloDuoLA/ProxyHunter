using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyHunter
{
    public partial class FormExport : Form
    {
        public FormExport()
        {
            ////设置控件选中选中的模式
            ////单击单元格或行标题能够选中整行
            ////this.dgvMessage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ////不容许用户调整列的排列顺序
            ////this.dgvMessage.AllowUserToOrderColumns = false;
            ////容许用户调整列的大小
            ////this.dgvMessage.AllowUserToResizeColumns = true;
            ////容许用户调整行的大小
            ////this.dgvMessage.AllowUserToResizeRows = true;
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\pc\Desktop";//默认保存路径为桌面
            string fileName = "proxy_list";//默认保存文件名
            string filter = "Files(*.txt)|*.txt";//指定保存文件类型
            string title = "选择代理列表保存路径";
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = filter;
            saveFileDialog.Title = title;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = saveFileDialog.FileName;
            }

            
            StreamWriter sw = new StreamWriter(path,false);
            for (int i = 0; i < this.dgvMessage.Rows.Count - 1; i++)
            {
                string? proxyMSG = this.dgvMessage.Rows[i].Cells[0].Value.ToString() + " "
                                   + this.dgvMessage.Rows[i].Cells[1].Value.ToString() + " "
                                   + this.dgvMessage.Rows[i].Cells[2].Value.ToString() + " "
                                   + this.dgvMessage.Rows[i].Cells[3].Value.ToString() + " "
                                   + this.dgvMessage.Rows[i].Cells[4].Value.ToString() + " "
                                   + this.dgvMessage.Rows[i].Cells[5].Value.ToString();
                
                sw.WriteLine(proxyMSG);
            }
            sw.Close();
            MessageBox.Show("导出成功!", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}
