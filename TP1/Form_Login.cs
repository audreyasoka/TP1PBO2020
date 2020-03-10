using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        // jika button login di klik
        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            // di isi kan ke atribut username punya nya kelas login
            login.username = Convert.ToString(txt_username.Text);
            // di isi kan ke atribut password punya nya kelas login
            login.password = Convert.ToString(txt_pass.Text); 

            // ketentuan password harus pbo123
            int kesamaan = String.Compare(login.password, "pbo123");

            // jika sama
            if (kesamaan == 0)
            {
                // maka dialihkan ke form 1
                MessageBox.Show("Anda Berhasil Masuk");
                Form1 fu = new Form1();

                fu.Show();
                this.Hide(); // form ini disembunyikan

            }

            // jika salah, tetap pada form login
            else
            {
                MessageBox.Show("Password Salah");

            }
        }

        // agar karakter yg terisi menjadi bintang
        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }
    }
}
