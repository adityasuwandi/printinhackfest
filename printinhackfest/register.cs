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
    public partial class register : Form
    {
        DBHelper db;
        public register()
        {
            InitializeComponent();
            db = new DBHelper();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = boxEmail.Text;
            string pass = boxPassword.Text;
            string namaToko = boxNamaToko.Text;
            try
            {
                db.InsertTableUser(email, pass, namaToko);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registrasi Gagal!\n" + ex.Message);
            }
        }
    }
}
