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
    public partial class XemHSBA : Form
    {
        string MAHS = null;
        OracleConnection conn = Connection.con;
        public XemHSBA()
        {
            InitializeComponent();
        }

        private void XemHSBA_Load(object sender, EventArgs e)
        {
            string cmd = "select * from DNX.HSBA";
            OracleDataAdapter oda = new OracleDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                dgv_HSlist.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void dgv_HSlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_HSlist.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_HSlist.CurrentRow.Selected = true;
                MAHS = dgv_HSlist.Rows[e.RowIndex].Cells["MA_HSBA"].FormattedValue.ToString();
                (new Dichvu(MAHS)).ShowDialog();
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
