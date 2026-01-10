namespace PerpusLSP
{
    partial class Login
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
            lblRole = new Label();
            txtusername = new TextBox();
            labeluname = new Label();
            labelpassword = new Label();
            txtpassword = new TextBox();
            btnadmin = new Button();
            btnanggota = new Button();
            labelatau = new Label();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AccessibleName = "";
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(118, 27);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(190, 38);
            lblRole.TabIndex = 0;
            lblRole.Text = "Login Sebagai";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(127, 108);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(160, 27);
            txtusername.TabIndex = 2;
            // 
            // labeluname
            // 
            labeluname.AutoSize = true;
            labeluname.Location = new Point(127, 82);
            labeluname.Name = "labeluname";
            labeluname.Size = new Size(75, 20);
            labeluname.TabIndex = 3;
            labeluname.Text = "Username";
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Location = new Point(127, 153);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(70, 20);
            labelpassword.TabIndex = 5;
            labelpassword.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(127, 179);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(160, 27);
            txtpassword.TabIndex = 4;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // btnadmin
            // 
            btnadmin.Location = new Point(150, 228);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(114, 38);
            btnadmin.TabIndex = 6;
            btnadmin.Text = "Login Admin";
            btnadmin.UseVisualStyleBackColor = true;
            btnadmin.Click += btnadmin_Click;
            // 
            // btnanggota
            // 
            btnanggota.Location = new Point(150, 304);
            btnanggota.Name = "btnanggota";
            btnanggota.Size = new Size(114, 48);
            btnanggota.TabIndex = 7;
            btnanggota.Text = "Cek Katalog";
            btnanggota.UseVisualStyleBackColor = true;
            btnanggota.Click += btnanggota_Click;
            // 
            // labelatau
            // 
            labelatau.AutoSize = true;
            labelatau.Location = new Point(184, 275);
            labelatau.Name = "labelatau";
            labelatau.Size = new Size(38, 20);
            labelatau.TabIndex = 9;
            labelatau.Text = "atau";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 384);
            Controls.Add(labelatau);
            Controls.Add(btnanggota);
            Controls.Add(btnadmin);
            Controls.Add(labelpassword);
            Controls.Add(txtpassword);
            Controls.Add(labeluname);
            Controls.Add(txtusername);
            Controls.Add(lblRole);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRole;
        private TextBox txtusername;
        private Label labeluname;
        private Label labelpassword;
        private TextBox txtpassword;
        private Button btnadmin;
        private Button btnanggota;
        private Label labelatau;
    }
}