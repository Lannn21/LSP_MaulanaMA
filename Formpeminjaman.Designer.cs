namespace PerpusLSP
{
    partial class Formpeminjaman
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
            dgvanggota = new DataGridView();
            dgvbuku = new DataGridView();
            txtidanggota = new TextBox();
            txtidbuku = new TextBox();
            btnpinjam = new Button();
            lblanggota = new Label();
            lblbuku = new Label();
            lblpinjam = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvanggota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvbuku).BeginInit();
            SuspendLayout();
            // 
            // dgvanggota
            // 
            dgvanggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvanggota.Location = new Point(22, 56);
            dgvanggota.Name = "dgvanggota";
            dgvanggota.RowHeadersWidth = 51;
            dgvanggota.Size = new Size(412, 204);
            dgvanggota.TabIndex = 0;
            // 
            // dgvbuku
            // 
            dgvbuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbuku.Location = new Point(472, 56);
            dgvbuku.Name = "dgvbuku";
            dgvbuku.RowHeadersWidth = 51;
            dgvbuku.Size = new Size(523, 204);
            dgvbuku.TabIndex = 1;
            // 
            // txtidanggota
            // 
            txtidanggota.Location = new Point(428, 313);
            txtidanggota.Name = "txtidanggota";
            txtidanggota.Size = new Size(117, 27);
            txtidanggota.TabIndex = 2;
            // 
            // txtidbuku
            // 
            txtidbuku.Location = new Point(428, 368);
            txtidbuku.Name = "txtidbuku";
            txtidbuku.Size = new Size(117, 27);
            txtidbuku.TabIndex = 3;
            // 
            // btnpinjam
            // 
            btnpinjam.Location = new Point(440, 412);
            btnpinjam.Name = "btnpinjam";
            btnpinjam.Size = new Size(94, 40);
            btnpinjam.TabIndex = 4;
            btnpinjam.Text = "Pinjam";
            btnpinjam.UseVisualStyleBackColor = true;
            btnpinjam.Click += btnPinjam_Click;
            // 
            // lblanggota
            // 
            lblanggota.AutoSize = true;
            lblanggota.Location = new Point(440, 287);
            lblanggota.Name = "lblanggota";
            lblanggota.Size = new Size(86, 20);
            lblanggota.TabIndex = 5;
            lblanggota.Text = "ID Anggota";
            // 
            // lblbuku
            // 
            lblbuku.AutoSize = true;
            lblbuku.Location = new Point(453, 345);
            lblbuku.Name = "lblbuku";
            lblbuku.Size = new Size(60, 20);
            lblbuku.TabIndex = 6;
            lblbuku.Text = "ID Buku";
            // 
            // lblpinjam
            // 
            lblpinjam.AutoSize = true;
            lblpinjam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpinjam.Location = new Point(22, 9);
            lblpinjam.Name = "lblpinjam";
            lblpinjam.Size = new Size(254, 31);
            lblpinjam.TabIndex = 7;
            lblpinjam.Text = "Form Peminjaman Buku";
            // 
            // Formpeminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 464);
            Controls.Add(lblpinjam);
            Controls.Add(lblbuku);
            Controls.Add(lblanggota);
            Controls.Add(btnpinjam);
            Controls.Add(txtidbuku);
            Controls.Add(txtidanggota);
            Controls.Add(dgvbuku);
            Controls.Add(dgvanggota);
            Name = "Formpeminjaman";
            Text = "Formpeminjaman";
            ((System.ComponentModel.ISupportInitialize)dgvanggota).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvbuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvanggota;
        private DataGridView dgvbuku;
        private TextBox txtidanggota;
        private TextBox txtidbuku;
        private Button btnpinjam;
        private Label lblanggota;
        private Label lblbuku;
        private Label lblpinjam;
    }
}