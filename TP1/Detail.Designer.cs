namespace TP1
{
    partial class Detail
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
            this.detail_nama = new System.Windows.Forms.Label();
            this.detail_harga = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.detail_foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // detail_nama
            // 
            this.detail_nama.AutoSize = true;
            this.detail_nama.Font = new System.Drawing.Font("League Spartan", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_nama.Location = new System.Drawing.Point(144, 50);
            this.detail_nama.Name = "detail_nama";
            this.detail_nama.Size = new System.Drawing.Size(78, 26);
            this.detail_nama.TabIndex = 1;
            this.detail_nama.Text = "Nama";
            // 
            // detail_harga
            // 
            this.detail_harga.AutoSize = true;
            this.detail_harga.Font = new System.Drawing.Font("League Spartan", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_harga.Location = new System.Drawing.Point(144, 75);
            this.detail_harga.Name = "detail_harga";
            this.detail_harga.Size = new System.Drawing.Size(80, 26);
            this.detail_harga.TabIndex = 2;
            this.detail_harga.Text = "Harga";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TP1.Properties.Resources.arrow_back_icon;
            this.pictureBox2.Location = new System.Drawing.Point(336, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // detail_foto
            // 
            this.detail_foto.Location = new System.Drawing.Point(12, 24);
            this.detail_foto.Name = "detail_foto";
            this.detail_foto.Size = new System.Drawing.Size(126, 124);
            this.detail_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detail_foto.TabIndex = 0;
            this.detail_foto.TabStop = false;
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 174);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.detail_harga);
            this.Controls.Add(this.detail_nama);
            this.Controls.Add(this.detail_foto);
            this.Name = "message";
            this.Text = "message";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox detail_foto;
        private System.Windows.Forms.Label detail_nama;
        private System.Windows.Forms.Label detail_harga;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}