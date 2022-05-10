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
    public partial class XemTTBN : Form
    {
        OracleConnection conn = Connection.con;
        public XemTTBN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CMND = txt_CMND.Text;
            if (CMND.Length < 8) {
                try
                {
                    string cmd = "select * from DNX.BENHNHAN where MA_BN = '" + CMND + "'";
                    OracleDataAdapter oda = new OracleDataAdapter(cmd, conn);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dgv_BNlist.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                catch (Exception) {
                    MessageBox.Show("Thông báo","Mã bệnh nhân không tồn tại");
                }
            }
            else
            {
                try
                {
                    string cmd = "select * from DNX.BENHNHAN where CMND = '" + CMND + "'";
                    OracleDataAdapter oda = new OracleDataAdapter(cmd, conn);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dgv_BNlist.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông báo", "CMND không tồn tại");
                }
            }
            
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MenuTT()).ShowDialog();
            this.Close();
        }
    }
}
