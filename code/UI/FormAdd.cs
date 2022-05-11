using ClassLibrary;
namespace ProxyHunter
{
    public partial class FormAdd : Form
    {
        public static int proxyAddRowsCount;

        public FormAdd()
        {
            InitializeComponent();
        }

        public void btnConfirm_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvAddMessage.ColumnCount = 2;
            dgvAddMessage.ColumnHeadersVisible = true;

            //避免重复输入同样的数据
            if (dgvAddMessage.Rows.Count > 0)
            {
                for (int i = 0; i < dgvAddMessage.Rows.Count - 1; i++)
                {
                    if (dgvAddMessage.Rows[i].Cells["proxy_ip"].Value?.ToString() == IPAddress.Text.Trim().ToString() &
                        dgvAddMessage.Rows[i].Cells["proxy_port"].Value?.ToString() == port.Text.Trim().ToString())
                    {
                        MessageBox.Show(IPAddress.Text + ":" + port.Text + "该代理已存在待添加框中！");
                        return;
                    }

                }
            }

            if (IPAddress.Text.Trim() != "" & port.Text.Trim() !="")
            {
                dgvAddMessage.Rows.Add(IPAddress.Text.Trim(), port.Text.Trim());
            }

        }
    }
}
