using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PH2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string u = username.Text;
            string p = password.Text;
            try
            {
                Connection.name = u;
                Connection.con = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-AAMU6EJ)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=PHANHE2))));User Id=" + u + ";Password=" + p + ";");
                Connection.con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select VAITRO from DNX.NHANVIEN where MA_NV = '" + u + "' ";
                cmd.Connection = Connection.con;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string type = dr.GetString(0);
                if (type == "Cơ sở y tế")
                {
                    this.Hide();
                    (new MenuCSYT()).ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    (new MenuTT()).ShowDialog();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo","Sai tài khoản hoặc mật khẩu");
            }
            this.Close();
        }
    }

    public static class Connection
    {
        public static OracleConnection con = null;
        public static string name = null;
    }
}
