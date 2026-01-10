namespace PerpusLSP
{
    partial class Formanggota
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
            lblnama = new Label();
            lblalamat = new Label();
            txtnamaanggota = new TextBox();
            txtalamatanggota = new TextBox();
            lblAnggota = new Label();
            btnsimpananggota = new Button();
            SuspendLayout();
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Location = new Point(27, 84);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(49, 20);
            lblnama.TabIndex = 0;
            lblnama.Text = "Nama";
            // 
            // lblalamat
            // 
            lblalamat.AutoSize = true;
            lblalamat.Location = new Point(27, 154);
            lblalamat.Name = "lblalamat";
            lblalamat.Size = new Size(57, 20);
            lblalamat.TabIndex = 1;
            lblalamat.Text = "Alamat";
            // 
            // txtnamaanggota
            // 
            txtnamaanggota.Location = new Point(99, 81);
            txtnamaanggota.Name = "txtnamaanggota";
            txtnamaanggota.Size = new Size(248, 27);
            txtnamaanggota.TabIndex = 2;
            txtnamaanggota.KeyPress += txtnamaanggota_KeyPress;
            // 
            // txtalamatanggota
            // 
            txtalamatanggota.Location = new Point(99, 151);
            txtalamatanggota.Name = "txtalamatanggota";
            txtalamatanggota.Size = new Size(248, 27);
            txtalamatanggota.TabIndex = 3;
            // 
            // lblAnggota
            // 
            lblAnggota.AutoSize = true;
            lblAnggota.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnggota.Location = new Point(3, 9);
            lblAnggota.Name = "lblAnggota";
            lblAnggota.Size = new Size(304, 31);
            lblAnggota.TabIndex = 4;
            lblAnggota.Text = "Form Anggota Perpustakaan";
            // 
            // btnsimpananggota
            // 
            btnsimpananggota.Location = new Point(137, 239);
            btnsimpananggota.Name = "btnsimpananggota";
            btnsimpananggota.Size = new Size(120, 43);
            btnsimpananggota.TabIndex = 5;
            btnsimpananggota.Text = "Simpan";
            btnsimpananggota.UseVisualStyleBackColor = true;
            btnsimpananggota.Click += btnSimpan_Click;
            // 
            // Formanggota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 372);
            Controls.Add(btnsimpananggota);
            Controls.Add(lblAnggota);
            Controls.Add(txtalamatanggota);
            Controls.Add(txtnamaanggota);
            Controls.Add(lblalamat);
            Controls.Add(lblnama);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Formanggota";
            Text = "Formanggota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnama;
        private Label lblalamat;
        private TextBox txtnamaanggota;
        private TextBox txtalamatanggota;
        private Label lblAnggota;
        private Button btnsimpananggota;
    }
}