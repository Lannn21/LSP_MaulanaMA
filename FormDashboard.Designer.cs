namespace PerpusLSP
{
    partial class FormDashboard
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
            btnanggota = new Button();
            btnbuku = new Button();
            btnkatalog = new Button();
            btnpinjam = new Button();
            lblPerpus = new Label();
            label1 = new Label();
            btnriwayat = new Button();
            SuspendLayout();
            // 
            // btnanggota
            // 
            btnanggota.Location = new Point(133, 113);
            btnanggota.Name = "btnanggota";
            btnanggota.Size = new Size(202, 53);
            btnanggota.TabIndex = 0;
            btnanggota.Text = "Tambah Anggota";
            btnanggota.UseVisualStyleBackColor = true;
            btnanggota.Click += btnanggota_Click;
            // 
            // btnbuku
            // 
            btnbuku.Location = new Point(133, 183);
            btnbuku.Name = "btnbuku";
            btnbuku.Size = new Size(202, 53);
            btnbuku.TabIndex = 1;
            btnbuku.Text = "Tambah Buku";
            btnbuku.UseVisualStyleBackColor = true;
            btnbuku.Click += btnbuku_Click;
            // 
            // btnkatalog
            // 
            btnkatalog.Location = new Point(133, 320);
            btnkatalog.Name = "btnkatalog";
            btnkatalog.Size = new Size(202, 53);
            btnkatalog.TabIndex = 3;
            btnkatalog.Text = "Buka Katalog";
            btnkatalog.UseVisualStyleBackColor = true;
            btnkatalog.Click += btnkatalog_Click;
            // 
            // btnpinjam
            // 
            btnpinjam.Location = new Point(133, 252);
            btnpinjam.Name = "btnpinjam";
            btnpinjam.Size = new Size(202, 53);
            btnpinjam.TabIndex = 2;
            btnpinjam.Text = "Peminjaman";
            btnpinjam.UseVisualStyleBackColor = true;
            btnpinjam.Click += btnpinjam_Click;
            // 
            // lblPerpus
            // 
            lblPerpus.AutoSize = true;
            lblPerpus.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerpus.Location = new Point(104, 15);
            lblPerpus.Name = "lblPerpus";
            lblPerpus.Size = new Size(269, 50);
            lblPerpus.TabIndex = 11;
            lblPerpus.Text = "PERPUSINDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 65);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 12;
            label1.Text = "Library Dashboard";
            // 
            // btnriwayat
            // 
            btnriwayat.Location = new Point(133, 394);
            btnriwayat.Name = "btnriwayat";
            btnriwayat.Size = new Size(202, 53);
            btnriwayat.TabIndex = 13;
            btnriwayat.Text = "Pengembalian";
            btnriwayat.UseVisualStyleBackColor = true;
            btnriwayat.Click += btnriwayat_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 459);
            Controls.Add(btnriwayat);
            Controls.Add(label1);
            Controls.Add(lblPerpus);
            Controls.Add(btnkatalog);
            Controls.Add(btnpinjam);
            Controls.Add(btnbuku);
            Controls.Add(btnanggota);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormDashboard";
            Text = "PerpustakaanService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnanggota;
        private Button btnbuku;
        private Button btnkatalog;
        private Button btnpinjam;
        private Label lblPerpus;
        private Label label1;
        private Button btnriwayat;
    }
}