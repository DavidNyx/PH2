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
    public partial class Dichvu : Form
    {
        string mahs = null;
        OracleConnection conn = Connection.con;
        public Dichvu(string value)
        {
            InitializeComponent();
            mahs = value;
        }

        private void Dichvu_Load(object sender, EventArgs e)
        {
            string cmd = "select * from DNX.HSBA_DV where MA_HSBA = '" + mahs + "'";
            OracleDataAdapter oda = new OracleDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                dgv_DVlist.DataSource = ds.Tables[0].DefaultView;
            }
        }
    }
}
