using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH2
{
    public partial class MenuTT : Form
    {
        public MenuTT()
        {
            InitializeComponent();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).ShowDialog();
            this.Close();
        }

        private void btn_Select_NV_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new XemTTNV()).ShowDialog();
            this.Close();
        }

        private void btn_Select_BN_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new XemTTBN()).ShowDialog();
            this.Close();
        }

        private void btn_Select_HSBA_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new XemHSBA()).ShowDialog();
            this.Close();
        }
    }
}
