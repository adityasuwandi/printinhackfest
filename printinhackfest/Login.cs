using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printinhackfest
{
    public partial class Login : Form
    {
        Form1 utama = new Form1();
        int id;
        string email, password;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            password = passBox.Text;
            email = userBox.Text;
            //utama.Activate;
             
        }
    }
}
