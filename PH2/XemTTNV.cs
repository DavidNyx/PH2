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
    public partial class XemTTNV : Form
    {
        OracleConnection conn = Connection.con;
        public XemTTNV()
        {
            InitializeComponent();
        }

        private void XemTTNV_Load(object sender, EventArgs e)
        {
            string cmd = "select * from DNX.NHANVIEN";
            OracleDataAdapter oda = new OracleDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                dgv_NVlist.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MenuTT()).ShowDialog();
            this.Close();
        }
    }
}
