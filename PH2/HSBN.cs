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
    public partial class HSBN : Form
    {
        OracleConnection conn = Connection.con;
        public HSBN()
        {
            InitializeComponent();
        }

        private void HSBN_Load(object sender, EventArgs e)
        {
            string cmd = "select * from DNX.BENHNHAN";
            OracleDataAdapter oda = new OracleDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                dgv_BNlist.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            this.Close();
        }
    }
}
