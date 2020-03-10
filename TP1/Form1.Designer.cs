namespace TP1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSemua = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_cari = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.label_katalog = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPencarian = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.buy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 309);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblSemua
            // 
            this.lblSemua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSemua.AutoSize = true;
            this.lblSemua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSemua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSemua.Location = new System.Drawing.Point(3, 9);
            this.lblSemua.Name = "lblSemua";
            this.lblSemua.Size = new System.Drawing.Size(106, 17);
            this.lblSemua.TabIndex = 9;
            this.lblSemua.Text = "Semua Barang:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.comboBox1.Location = new System.Drawing.Point(473, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Jenis Barang";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100rb-200rb",
            "200rb-500rb",
            "500rb-1jt"});
            this.comboBox2.Location = new System.Drawing.Point(600, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Range Harga";
            // 
            // button_cari
            // 
            this.button_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cari.Location = new System.Drawing.Point(727, 103);
            this.button_cari.Name = "button_cari";
            this.button_cari.Size = new System.Drawing.Size(69, 23);
            this.button_cari.TabIndex = 2;
            this.button_cari.Text = "Cari";
            this.button_cari.UseVisualStyleBackColor = true;
            this.button_cari.Click += new System.EventHandler(this.button_cari_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_menu.Location = new System.Drawing.Point(51, 171);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(79, 20);
            this.label_menu.TabIndex = 4;
            this.label_menu.Text = "Menu Beli";
            // 
            // label_katalog
            // 
            this.label_katalog.AutoSize = true;
            this.label_katalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_katalog.Location = new System.Drawing.Point(55, 227);
            this.label_katalog.Name = "label_katalog";
            this.label_katalog.Size = new System.Drawing.Size(63, 20);
            this.label_katalog.TabIndex = 6;
            this.label_katalog.Text = "Katalog";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblPencarian);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSemua);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(156, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 354);
            this.panel1.TabIndex = 0;
            // 
            // lblPencarian
            // 
            this.lblPencarian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPencarian.AutoSize = true;
            this.lblPencarian.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPencarian.Location = new System.Drawing.Point(3, 10);
            this.lblPencarian.Name = "lblPencarian";
            this.lblPencarian.Size = new System.Drawing.Size(111, 17);
            this.lblPencarian.TabIndex = 11;
            this.lblPencarian.Text = "Hasil Pencarian:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(459, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "1801165 - Audrey Asokawati";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 97);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(55, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Log Out";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = global::TP1.Properties.Resources.Logout_icon;
            this.pictureBox4.Location = new System.Drawing.Point(12, 391);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // cat
            // 
            this.cat.Image = global::TP1.Properties.Resources.website_icon;
            this.cat.Location = new System.Drawing.Point(12, 211);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(37, 47);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cat.TabIndex = 10;
            this.cat.TabStop = false;
            this.cat.Click += new System.EventHandler(this.cat_Click);
            // 
            // buy
            // 
            this.buy.Image = global::TP1.Properties.Resources.cart_icon;
            this.buy.Location = new System.Drawing.Point(12, 158);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(37, 47);
            this.buy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buy.TabIndex = 1;
            this.buy.TabStop = false;
            this.buy.Click += new System.EventHandler(this.buy_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP1.Properties.Resources.shop_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_katalog);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.button_cari);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button_cari;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Label label_katalog;
        private System.Windows.Forms.Label lblSemua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buy;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPencarian;
    }
}

