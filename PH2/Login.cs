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
            this.Hide();
            switch(u)
            {
                case "CSYT":
                    (new MenuCSYT()).ShowDialog();
                    break;
            }
            this.Close();
        }
    }
}
