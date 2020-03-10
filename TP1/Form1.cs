using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Properties;

namespace TP1
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // memanggil method katalog dengan parameter null
            Katalog();
            lblPencarian.Hide(); // label hide
        }

        // methpd katalog
        public void Katalog(int j = 0, int h = 0)
        {
            // boolean ada barangnya atau engga
            bool keadaan = false;

            // array of object
            Menu[] menus = new Menu[5];
           
            // mengisi array indeks ke 0 - 4
            menus[0] = new Menu();
            menus[0].Nama = "TV";
            menus[0].Harga = "Rp1.000.000";
            menus[0].Foto = Resources.tv;
            menus[0].Button = "btn0";
            menus[0].kategori = 1;
            menus[0].harga_asli = 1000;

            menus[1] = new Menu();
            menus[1].Nama = "HP";
            menus[1].Foto = Resources.hp;
            menus[1].Harga = "Rp800.000";
            menus[1].Button = "btn1";
            menus[1].kategori = 1;
            menus[1].harga_asli = 800;

            menus[2] = new Menu();
            menus[2].Nama = "Sushi";
            menus[2].Foto = Resources.makanan;
            menus[2].Harga = "Rp100.000";
            menus[2].Button = "btn2";
            menus[2].kategori = 3;
            menus[2].harga_asli = 100;

            menus[3] = new Menu();
            menus[3].Nama = "Steak";
            menus[3].Foto = Resources.steak;
            menus[3].Harga = "Rp150.000";
            menus[3].kategori = 3;
            menus[3].Button = "btn3";
            menus[3].harga_asli = 150;

            menus[4] = new Menu();
            menus[4].Nama = "Sweater";
            menus[4].Foto = Resources.baju;
            menus[4].kategori = 2;
            menus[4].Button = "btn4";
            menus[4].Harga = "Rp450.000";
            menus[4].harga_asli = 450;


            // perulangan untuk add ke layout pannel
            for (int i = 0; i < menus.Length; i++)
            {
                // jika parameter j nya null 
                if (j == 0)
                { // menampilkan semua barang
                    flowLayoutPanel1.Controls.Add(menus[i]);
                    keadaan = true; // ada barang yg ditampilkan jadi true
                }

                // jika ada parameter j dan h nya, j = pilihan jenis barang, h = pilihan range harga
                else
                {
                    // jika pilihannya sama dengan array yg lg dalam perulangan
                    if(j == menus[i].kategori)
                    {
                        // dicek milih range harga nya yg mana, kalau ada datanya maka akan di add ke flow layout
                        if (h == 1)
                        {
                            if ((menus[i].harga_asli >= 100) && (menus[i].harga_asli <= 200))
                            {
                                flowLayoutPanel1.Controls.Add(menus[i]);
                                keadaan = true;
                            }
                        }
                        else if(h == 2)
                        {
                            if ((menus[i].harga_asli >= 200) && (menus[i].harga_asli <= 500))
                            {
                                flowLayoutPanel1.Controls.Add(menus[i]);
                                keadaan = true;
                            }
                        }
                        else if(h == 3)
                        {
                            if ((menus[i].harga_asli >= 500) && (menus[i].harga_asli <= 1000))
                            {
                                flowLayoutPanel1.Controls.Add(menus[i]);
                                keadaan = true;
                            }
                        }
                    }
                }
            }
            
            // jika tidak ada barang yg ditampilkan
            if(keadaan == false)
            {
                MessageBox.Show("Pencarian Tidak Ditemukan");
            }
        }

        // metod jika button cari di klik
        private void button_cari_Click(object sender, EventArgs e)
        {
            int pilihan1 = comboBox1.SelectedIndex + 1; // ambil indeks pilihan jenis barang
            int pilihan2 = comboBox2.SelectedIndex + 1; // ambil indeks pilihan range harga
            // indeks di tambah 1 menghindari angka 0 pada indeks 0

            // tampilan flow di kosongkan
            flowLayoutPanel1.Controls.Clear();

            // jika sudah milih jenis dan range harga
            if (pilihan1 > 0 && pilihan2 > 0)
            {
                lblSemua.Hide(); // label bacaan semua barang di hide
                lblPencarian.Show(); // label bacaan hasil pencarian di show
                Katalog(pilihan1, pilihan2); // manggil metod katalog dengan parameter
            }
            else
            {
                // jika jenis atau range belum dipilih
                MessageBox.Show("Mohon pilih jenis barang & range harga.");
            }
        }

        // klik icon buy
        private void buy_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear(); // di clear flow panel nya
            lblPencarian.Hide(); // label pencarian di hide
            lblSemua.Show(); // menampilkan label "semua barang"
            Katalog(); // manggil katalog
        }

        // jika icon catalog di klik maka akan pindah ke browser
        private void cat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://catalogclothing.com.au/");
        }

        // klik log out
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login(); 
            fl.Show(); // menampilkan form login
            this.Hide(); // menyembunyikan form1
        }

    }
}
