namespace PerpusLSP
{
    partial class Formbuku
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
            btnsimpanbuku = new Button();
            lblBuku = new Label();
            txtpengarang = new TextBox();
            txtjudul = new TextBox();
            lblpengarang = new Label();
            lbljudul = new Label();
            txttahunbuku = new TextBox();
            lblTahun = new Label();
            SuspendLayout();
            // 
            // btnsimpanbuku
            // 
            btnsimpanbuku.Location = new Point(136, 239);
            btnsimpanbuku.Name = "btnsimpanbuku";
            btnsimpanbuku.Size = new Size(120, 43);
            btnsimpanbuku.TabIndex = 11;
            btnsimpanbuku.Text = "Simpan";
            btnsimpanbuku.UseVisualStyleBackColor = true;
            btnsimpanbuku.Click += btnsimpanbuku_Click;
            // 
            // lblBuku
            // 
            lblBuku.AutoSize = true;
            lblBuku.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuku.Location = new Point(2, 9);
            lblBuku.Name = "lblBuku";
            lblBuku.Size = new Size(265, 31);
            lblBuku.TabIndex = 10;
            lblBuku.Text = "Form Buku Perpustakaan";
            // 
            // txtpengarang
            // 
            txtpengarang.Location = new Point(111, 126);
            txtpengarang.Name = "txtpengarang";
            txtpengarang.Size = new Size(248, 27);
            txtpengarang.TabIndex = 9;
            // 
            // txtjudul
            // 
            txtjudul.Location = new Point(111, 81);
            txtjudul.Name = "txtjudul";
            txtjudul.Size = new Size(248, 27);
            txtjudul.TabIndex = 8;
            // 
            // lblpengarang
            // 
            lblpengarang.AutoSize = true;
            lblpengarang.Location = new Point(26, 129);
            lblpengarang.Name = "lblpengarang";
            lblpengarang.Size = new Size(79, 20);
            lblpengarang.TabIndex = 7;
            lblpengarang.Text = "Pengarang";
            // 
            // lbljudul
            // 
            lbljudul.AutoSize = true;
            lbljudul.Location = new Point(26, 84);
            lbljudul.Name = "lbljudul";
            lbljudul.Size = new Size(43, 20);
            lbljudul.TabIndex = 6;
            lbljudul.Text = "Judul";
            // 
            // txttahunbuku
            // 
            txttahunbuku.Location = new Point(111, 173);
            txttahunbuku.Name = "txttahunbuku";
            txttahunbuku.Size = new Size(248, 27);
            txttahunbuku.TabIndex = 13;
            // 
            // lblTahun
            // 
            lblTahun.AutoSize = true;
            lblTahun.Location = new Point(26, 176);
            lblTahun.Name = "lblTahun";
            lblTahun.Size = new Size(47, 20);
            lblTahun.TabIndex = 12;
            lblTahun.Text = "Tahun";
            // 
            // Formbuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 372);
            Controls.Add(txttahunbuku);
            Controls.Add(lblTahun);
            Controls.Add(btnsimpanbuku);
            Controls.Add(lblBuku);
            Controls.Add(txtpengarang);
            Controls.Add(txtjudul);
            Controls.Add(lblpengarang);
            Controls.Add(lbljudul);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Formbuku";
            Text = "Formbuku";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsimpanbuku;
        private Label lblBuku;
        private TextBox txtpengarang;
        private TextBox txtjudul;
        private Label lblpengarang;
        private Label lbljudul;
        private TextBox txttahunbuku;
        private Label lblTahun;
    }
}