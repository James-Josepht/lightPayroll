using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;

namespace lighPayroll
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void backHomeButtonClick(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void registerAccountTextChange(object sender, EventArgs e)
        {
            string account = registerAccountBox.Text;
        }
        private void registerPassTextChange(object sender, EventArgs e)
        {
            string password = registerPassBox.Text;
        }

        private void registerButtonClick(object sender, EventArgs e)
        {

        }
        private void showPassBoxClick(object sender, EventArgs e)
        {

        }
    }
}
