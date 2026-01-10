namespace PerpusLSP
{
    partial class Formkatalog
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
            dgvkatalog = new DataGridView();
            txtsearch = new TextBox();
            btnsearch = new Button();
            lbllist = new Label();
            lblcari = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvkatalog).BeginInit();
            SuspendLayout();
            // 
            // dgvkatalog
            // 
            dgvkatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkatalog.Location = new Point(12, 111);
            dgvkatalog.Name = "dgvkatalog";
            dgvkatalog.RowHeadersWidth = 51;
            dgvkatalog.Size = new Size(776, 327);
            dgvkatalog.TabIndex = 0;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(456, 61);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(226, 34);
            txtsearch.TabIndex = 1;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(697, 61);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(79, 34);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "search";
            btnsearch.UseCompatibleTextRendering = true;
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // lbllist
            // 
            lbllist.AutoSize = true;
            lbllist.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllist.Location = new Point(12, 12);
            lbllist.Name = "lbllist";
            lbllist.Size = new Size(330, 46);
            lbllist.TabIndex = 11;
            lbllist.Text = "List Buku Perpusindo";
            // 
            // lblcari
            // 
            lblcari.AutoSize = true;
            lblcari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcari.Location = new Point(456, 25);
            lblcari.Name = "lblcari";
            lblcari.Size = new Size(97, 28);
            lblcari.TabIndex = 12;
            lblcari.Text = "Cari Judul";
            // 
            // Formkatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblcari);
            Controls.Add(lbllist);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(dgvkatalog);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Formkatalog";
            Text = "Formkatalog";
            ((System.ComponentModel.ISupportInitialize)dgvkatalog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvkatalog;
        private TextBox txtsearch;
        private Button btnsearch;
        private Label lbllist;
        private Label lblcari;
    }
}