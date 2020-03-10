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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        // jika klik tombol kembali, maka form detail di sembunyikan dan kembali pada form 1
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // atribut
        private string _nama1;
        private string _harga1;
        private Image _foto1;

        // get set
        public string Nama_Detail
        {
            get { return _nama1; ; }
            set { _nama1 = value; detail_nama.Text = value; }
        }

        public string Harga_Detail

        {
            get { return _harga1; }
            set { _harga1 = value; detail_harga.Text = value; }
        }

        public Image Foto_Detail
        {
            get { return _foto1; }
            set { _foto1 = value; detail_foto.Image = value; }
        }


    }
}
