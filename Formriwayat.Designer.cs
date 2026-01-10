namespace PerpusLSP
{
    partial class Formriwayat
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
            dgvriwayat = new DataGridView();
            txtidpeminjam = new TextBox();
            txtidbuku = new TextBox();
            lblidnama = new Label();
            lblidbuku = new Label();
            btnkembali = new Button();
            lblpinjam = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvriwayat).BeginInit();
            SuspendLayout();
            // 
            // dgvriwayat
            // 
            dgvriwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvriwayat.Location = new Point(12, 62);
            dgvriwayat.Name = "dgvriwayat";
            dgvriwayat.RowHeadersWidth = 51;
            dgvriwayat.Size = new Size(776, 211);
            dgvriwayat.TabIndex = 0;
            // 
            // txtidpeminjam
            // 
            txtidpeminjam.Location = new Point(130, 299);
            txtidpeminjam.Name = "txtidpeminjam";
            txtidpeminjam.Size = new Size(125, 27);
            txtidpeminjam.TabIndex = 1;
            // 
            // txtidbuku
            // 
            txtidbuku.Location = new Point(130, 350);
            txtidbuku.Name = "txtidbuku";
            txtidbuku.Size = new Size(125, 27);
            txtidbuku.TabIndex = 2;
            // 
            // lblidnama
            // 
            lblidnama.AutoSize = true;
            lblidnama.Location = new Point(15, 299);
            lblidnama.Name = "lblidnama";
            lblidnama.Size = new Size(109, 20);
            lblidnama.TabIndex = 3;
            lblidnama.Text = "ID Peminjaman";
            // 
            // lblidbuku
            // 
            lblidbuku.AutoSize = true;
            lblidbuku.Location = new Point(15, 350);
            lblidbuku.Name = "lblidbuku";
            lblidbuku.Size = new Size(60, 20);
            lblidbuku.TabIndex = 4;
            lblidbuku.Text = "ID Buku";
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(130, 398);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(125, 40);
            btnkembali.TabIndex = 5;
            btnkembali.Text = "Pengembalian";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnKembalikan_Click;
            // 
            // lblpinjam
            // 
            lblpinjam.AutoSize = true;
            lblpinjam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpinjam.Location = new Point(12, 9);
            lblpinjam.Name = "lblpinjam";
            lblpinjam.Size = new Size(274, 31);
            lblpinjam.TabIndex = 8;
            lblpinjam.Text = "Form Pengembalian Buku";
            // 
            // Formriwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblpinjam);
            Controls.Add(btnkembali);
            Controls.Add(lblidbuku);
            Controls.Add(lblidnama);
            Controls.Add(txtidbuku);
            Controls.Add(txtidpeminjam);
            Controls.Add(dgvriwayat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Formriwayat";
            Text = "Formriwayat";
            ((System.ComponentModel.ISupportInitialize)dgvriwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvriwayat;
        private TextBox txtidpeminjam;
        private TextBox txtidbuku;
        private Label lblidnama;
        private Label lblidbuku;
        private Button btnkembali;
        private Label lblpinjam;
    }
}