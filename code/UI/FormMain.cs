using static System.Windows.Forms.DataFormats;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ClassLibrary;

using Microsoft.Win32;
using System.Runtime.InteropServices;
using SQLite;
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
            //容许用户调整列的大小
            this.dgvProxyMessage.AllowUserToResizeColumns = true;
            //容许用户调整行的大小
            this.dgvProxyMessage.AllowUserToResizeRows = true;

            SQLiteConnection db = ClassProxy.CreatDataBase();
            Console.WriteLine("Reading data");

            SQLiteCommand dbCommand = new SQLiteCommand(db);
            dbCommand.CommandText = "SELECT COUNT(*) FROM sqlite_master where type='table' and name='Proxy';";
            if (0 == Convert.ToInt32(dbCommand.ExecuteScalar<string>()))
            {
                //table - Proxy does not exist.
                db.CreateTable<ClassProxy.Proxy>();
            }
       
            var table = db.Table<ClassProxy.Proxy>();
            foreach (var s in table)
            {
                proxyIP = s.IP;
                proxyPort = s.Port;
                proxyStatus = s.Status;
                proxyCT = s.CT;
                proxyVT = s.VT;
                proxyComments = s.Conmments;

                dgvProxyMessage.Rows.Add(proxyIP, proxyPort, proxyStatus, proxyCT, proxyVT, proxyComments);
            }
            db.Close();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要关闭?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            /*else
            {

                DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);
                DirectoryInfo configDir = directoryInfo.Parent.Parent.Parent;
                string path = configDir + @"\config\proxyInitial.txt";
                StreamWriter sw = new StreamWriter(path, false);
                for (int i = 0; i < this.dgvProxyMessage.Rows.Count-1; i++)
                {
                    string? proxyMSG = this.dgvProxyMessage.Rows[i].Cells[0].Value.ToString() + ";"
                                       + this.dgvProxyMessage.Rows[i].Cells[1].Value.ToString() + ";"
                                       + this.dgvProxyMessage.Rows[i].Cells[2].Value.ToString() + ";"
                                       + this.dgvProxyMessage.Rows[i].Cells[3].Value.ToString() + ";"
                                       + this.dgvProxyMessage.Rows[i].Cells[4].Value.ToString() + ";"
                                       + this.dgvProxyMessage.Rows[i].Cells[5].Value.ToString();

                    sw.WriteLine(proxyMSG);
                }
                sw.Close();

            }*/
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
            if (form.DialogResult == DialogResult.OK)
            {
                if (form.dgvAddMessage.Rows.Count > 0)
                {
                    /*string dbPath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                        "ProxyHunter.db3");*/
                    string dbPath = Path.Combine(Environment.CurrentDirectory, "ProxyHunter.db3");
                    SQLiteConnection conn = new SQLiteConnection(dbPath);
                    for (int i = 0; i < form.dgvAddMessage.Rows.Count - 1; i++)
                    {
                        proxyIP = form.dgvAddMessage.Rows[i].Cells["proxy_ip"].Value?.ToString();
                        proxyPort = form.dgvAddMessage.Rows[i].Cells["proxy_port"].Value?.ToString();
                        proxyStatus = "未验证";
                        proxyCT = DateTime.Now.ToString();
                        proxyVT = "/";
                        proxyComments = "/";
                        dgvProxyMessage.Rows.Add(proxyIP, proxyPort, proxyStatus, proxyCT, proxyVT, proxyComments);

                        ClassProxy.Proxy newproxy = new ClassProxy.Proxy();
                        newproxy.IP = proxyIP;
                        newproxy.Port = proxyPort;
                        newproxy.Status = proxyStatus;
                        newproxy.CT = proxyCT;
                        newproxy.VT = proxyVT;
                        newproxy.Conmments = proxyComments;

                        conn.Insert(newproxy);
                    }
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除吗？", "删除代理", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                /*string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "ProxyHunter.db3");*/
                string dbPath = Path.Combine(Environment.CurrentDirectory, "ProxyHunter.db3");
                SQLiteConnection conn = new SQLiteConnection(dbPath);
                
                foreach (DataGridViewRow proxyMessageRow in dgvProxyMessage.SelectedRows)
                {
                    dgvProxyMessage.Rows.Remove(proxyMessageRow);
                    //int index = dgvProxyMessage.SelectedCells[0].RowIndex;
                    //string IP = dgvProxyMessage.Rows[index].Cells[0].Value.ToString().Trim();
                    //int indexPort = dgvProxyMessage.SelectedCells[0].RowIndex;
                    //string port = dgvProxyMessage.Rows[indexPort].Cells[0].Value.ToString().Trim();
                    //string port = dgvProxyMessage.Rows[index].Cells[1].Value.ToString().Trim();
                    string IP = proxyMessageRow.Cells[0].Value.ToString();
                    string port = proxyMessageRow.Cells[1].Value.ToString();

                    string sql = "DELETE FROM Proxy WHERE IP='" + IP + "' AND Port='" + port + "'";
                //db.Delete<Class1.Proxy>(newproxy.IP);
                    SQLiteCommand command = new SQLiteCommand(conn);
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    //conn.Delete<Class1.Proxy>(newProxy.IP); // Id is the primary key
                }
                conn.Close();
            }
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            FormImport form = new FormImport();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if (form.dgvMessage.Rows.Count > 0)
                {
                    /*string dbPath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                        "ProxyHunter.db3");*/
                    string dbPath = Path.Combine(Environment.CurrentDirectory, "ProxyHunter.db3");
                    SQLiteConnection conn = new SQLiteConnection(dbPath);

                    for (int i = 0; i < form.dgvMessage.Rows.Count - 1; i++)
                    {
                        proxyIP = form.dgvMessage.Rows[i].Cells["tp_c1"].Value?.ToString();
                        proxyPort = form.dgvMessage.Rows[i].Cells["tp_c2"].Value?.ToString();
                        proxyStatus = form.dgvMessage.Rows[i].Cells["tp_c3"].Value?.ToString();
                        proxyCT = form.dgvMessage.Rows[i].Cells["tp_c4"].Value?.ToString();
                        proxyVT = form.dgvMessage.Rows[i].Cells["tp_c5"].Value?.ToString();
                        proxyComments = form.dgvMessage.Rows[i].Cells["tp_c6"].Value?.ToString();
                        dgvProxyMessage.Rows.Add(proxyIP, proxyPort, proxyStatus, proxyCT, proxyVT, proxyComments);

                        ClassProxy.Proxy newproxy = new ClassProxy.Proxy();
                        newproxy.IP = proxyIP;
                        newproxy.Port = proxyPort;
                        newproxy.Status = proxyStatus;
                        newproxy.CT = proxyCT;
                        newproxy.VT = proxyVT;
                        newproxy.Conmments = proxyComments;
                        
                        conn.Insert(newproxy);
                    }
                    conn.Close();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FormExport form = new FormExport();
            foreach (DataGridViewRow proxyMessageRow in dgvProxyMessage.SelectedRows)
            {
                proxyIP = proxyMessageRow.Cells["proxy_ip"].Value?.ToString();
                proxyPort = proxyMessageRow.Cells["proxy_port"].Value?.ToString();
                proxyStatus = proxyMessageRow.Cells["proxy_stutas"].Value?.ToString();
                proxyCT = proxyMessageRow.Cells["proxy_ct"].Value?.ToString();
                proxyVT = proxyMessageRow.Cells["proxy_vt"].Value?.ToString();
                proxyComments = proxyMessageRow.Cells["proxy_comments"].Value?.ToString();
                form.dgvMessage.Rows.Add(proxyIP, proxyPort, proxyStatus, proxyCT, proxyVT, proxyComments);
            }
            form.ShowDialog();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            FormVerify form = new FormVerify();
            form.ShowDialog();
            string verifyURL = form.VerifyURL.Text.ToString();
            if (form.DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewRow proxyMessageRow in dgvProxyMessage.SelectedRows)
                {
                    string ip = proxyMessageRow.Cells[0].Value.ToString();
                    int port = int.Parse(proxyMessageRow.Cells[1].Value.ToString());
                    string rs = ClassProxy.ProxyVerify(ip, port, verifyURL);
                    MessageBox.Show(rs);
                    if (rs != null & rs != "Error")
                    {
                        proxyMessageRow.Cells[2].Value = "可用";
                        proxyMessageRow.Cells[4].Value = DateTime.Now.ToString();
                    }
                }
            }
        } 

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow proxyMessageRow in dgvProxyMessage.SelectedRows)
            {
                if (proxyMessageRow.Cells[2].Value.ToString() == "可用")
                {
                    //打开注册表键
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    string Proxy = proxyMessageRow.Cells[0].Value.ToString() + ":" + proxyMessageRow.Cells[1].Value.ToString();
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", Proxy);
                    MessageBox.Show("设置代理成功！", "代理猎手", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("设置代理失败！", "代理猎手", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                break;
            }
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

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProxyMessage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}