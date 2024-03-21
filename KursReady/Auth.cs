using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursReady
{
    public partial class Auth : Form
    {
        private bool _isAuthenticated = false;

        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager("C:\\Users\\Ikarushka\\source\\repos\\KursReady\\users.db");
            if (dbManager.CheckUser(AuthLog.Text, AuthPwd.Text))
            {
                _isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry!");
            }

        }

        private void goReg_Click(object sender, EventArgs e)
        {
            Reg reg_form = new Reg();
            reg_form.ShowDialog();
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false)
            {
                Application.Exit();
            }
                
        }
    }
}
