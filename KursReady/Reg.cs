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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void MakeReg_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager("C:\\Users\\Ikarushka\\source\\repos\\KursReady\\users.db") ;
            if (dbManager.AddUser(RegLogin.Text, regPwd.Text))
            {
                MessageBox.Show("Congratulation!");
            }
            else
            {
                MessageBox.Show("Sorry!");
            }
        }
    }
}
