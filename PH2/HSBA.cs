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
    public partial class HSBA : Form
    {
        OracleConnection conn = Connection.con;
        public HSBA()
        {
            InitializeComponent();
        }

        private void HSBA_Load(object sender, EventArgs e)
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

        public string getCSYT(OracleConnection conn)
        {
            string cyst = null;
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select CSYT from DNX.NHANVIEN where MA_NV = '" + Connection.name + "' ";
            cmd.Connection = Connection.con;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            cyst = dr.GetString(0);
            return cyst;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string csyt = getCSYT(conn);
            try
            {
                string cmd = "INSERT INTO DNX.HSBA(MA_HSBA, MA_BN, NGAY, CHUANDOAN, MA_BS, MA_KHOA, MA_CSYT, KETLUAN) VALUES "
                    + "'" + txt_Mahs.Text + "','" + txt_Mabn + "',CURRENT_DATE,'" + txt_Chandoan + "','" + txt_Mabs + "','" + txt_Makh + "','" + csyt + "','" + txt_Ketluan + "'";
                OracleCommand oda = new OracleCommand(cmd, conn);
                oda.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            string mahs = txt_Mahs.Text;
            try
            {
                string cmd = "DELETE FROM DNX.HSBA WHERE MA_HSBA = '" + mahs + "'";
                OracleCommand oda = new OracleCommand(cmd, conn);
                oda.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void dgv_HSlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_HSlist.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_HSlist.CurrentRow.Selected = true;
                txt_Mahs.Text = dgv_HSlist.Rows[e.RowIndex].Cells["MA_HSBA"].FormattedValue.ToString();
                txt_Mabn.Text = dgv_HSlist.Rows[e.RowIndex].Cells["MA_BN"].FormattedValue.ToString();
                txt_Chandoan.Text = dgv_HSlist.Rows[e.RowIndex].Cells["CHUANDOAN"].FormattedValue.ToString();
                txt_Mabs.Text = dgv_HSlist.Rows[e.RowIndex].Cells["MA_BS"].FormattedValue.ToString();
                txt_Makh.Text = dgv_HSlist.Rows[e.RowIndex].Cells["MA_KHOA"].FormattedValue.ToString();
                txt_Ketluan.Text = dgv_HSlist.Rows[e.RowIndex].Cells["KETLUAN"].FormattedValue.ToString();
            }
        }
    }
}
