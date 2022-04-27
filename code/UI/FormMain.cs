namespace ProxyHunter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除吗？", "删除代理", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            FormImport form = new FormImport();
            form.ShowDialog();
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