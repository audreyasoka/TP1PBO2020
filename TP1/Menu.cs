using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Properties;

namespace TP1
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        // atribut 
        private string _nama;
        private string _harga;
        private Image _foto;
        private String _button;
        
        // get set

        public int kategori { get; set; }
        public int harga_asli { get; set; }

        public string Nama
        {
            get { return _nama;; }
            // set label sesuai value
            set { _nama = value; label1.Text = value; }
        }

        public string Harga

        {
            get { return _harga; }
            // set harga sesuai value
            set { _harga = value; label2.Text = value;  }
        }

        public Image Foto
        {
            get { return _foto; }
            // set foto sesuai value
            set { _foto = value; pictureBox1.Image = value;  }
        }

        public String Button
        {
            get { return button1.Name; }
            // set button name sesuai value
            set { button1.Name = value; }
        }

        // jika button Beli di klik
        private void button1_Click(object sender, EventArgs e)
        {
            // memanggil kelas detail
            Detail msg = new Detail();
            // Button name dijadikan string s
            string s = (sender as Button).Name;
           
            // jika button name nya 0 maka tampilkan tv
            if(string.Compare(s, "btn0") == 0)
            {
                msg.Nama_Detail = "TV";
                msg.Harga_Detail = "Rp1.000.000";
                msg.Foto_Detail = Resources.tv;
                msg.Show();
            }

            // jika 1 maka tampilkan hp
            else if(string.Compare(s, "btn1") == 0)
            {
                msg.Nama_Detail = "HP";
                msg.Harga_Detail = "Rp800.000";
                msg.Foto_Detail = Resources.hp;
                msg.Show();
            }

            // jika 2 tampilkan sushi
            else if (string.Compare(s, "btn2") == 0)
            {
                msg.Nama_Detail = "Sushi";
                msg.Harga_Detail = "Rp100.000";
                msg.Foto_Detail = Resources.makanan;
                msg.Show();
            }

            // jika 3 maka tampilkan steak
            else if (string.Compare(s, "btn3") == 0)
            {
                msg.Nama_Detail = "Steak";
                msg.Harga_Detail = "Rp150.000";
                msg.Foto_Detail = Resources.steak;
                msg.Show();
            }

            // jika 4 maka tampilkan sweater
            else if (string.Compare(s, "btn4") == 0)
            {
                msg.Nama_Detail = "Sweater";
                msg.Harga_Detail = "Rp450.000";
                msg.Foto_Detail = Resources.baju;
                msg.Show();
            }

        }
    }
}
