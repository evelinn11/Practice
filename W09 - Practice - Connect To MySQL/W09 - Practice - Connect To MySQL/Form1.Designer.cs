namespace W09___Practice___Connect_To_MySQL
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
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Database = new System.Windows.Forms.Label();
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.tB_Database = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.dGV_Player = new System.Windows.Forms.DataGridView();
            this.dGV_Mahasiswa = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tB_KotaAsal = new System.Windows.Forms.TextBox();
            this.tB_Nama = new System.Windows.Forms.TextBox();
            this.tB_NIM = new System.Windows.Forms.TextBox();
            this.lb_KotaAsal = new System.Windows.Forms.Label();
            this.lb_Nama = new System.Windows.Forms.Label();
            this.lb_NIM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Mahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(41, 41);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(110, 25);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "Username";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(41, 87);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(106, 25);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Password";
            // 
            // lb_Database
            // 
            this.lb_Database.AutoSize = true;
            this.lb_Database.Location = new System.Drawing.Point(41, 132);
            this.lb_Database.Name = "lb_Database";
            this.lb_Database.Size = new System.Drawing.Size(104, 25);
            this.lb_Database.TabIndex = 2;
            this.lb_Database.Text = "Database";
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(173, 35);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(176, 31);
            this.tB_Username.TabIndex = 3;
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(173, 81);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.Size = new System.Drawing.Size(176, 31);
            this.tB_Password.TabIndex = 4;
            // 
            // tB_Database
            // 
            this.tB_Database.Location = new System.Drawing.Point(173, 129);
            this.tB_Database.Name = "tB_Database";
            this.tB_Database.Size = new System.Drawing.Size(176, 31);
            this.tB_Database.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(173, 184);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(152, 43);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // dGV_Player
            // 
            this.dGV_Player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Player.Location = new System.Drawing.Point(12, 768);
            this.dGV_Player.Name = "dGV_Player";
            this.dGV_Player.RowHeadersWidth = 82;
            this.dGV_Player.RowTemplate.Height = 33;
            this.dGV_Player.Size = new System.Drawing.Size(2456, 473);
            this.dGV_Player.TabIndex = 7;
            // 
            // dGV_Mahasiswa
            // 
            this.dGV_Mahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Mahasiswa.Location = new System.Drawing.Point(12, 260);
            this.dGV_Mahasiswa.Name = "dGV_Mahasiswa";
            this.dGV_Mahasiswa.RowHeadersWidth = 82;
            this.dGV_Mahasiswa.RowTemplate.Height = 33;
            this.dGV_Mahasiswa.Size = new System.Drawing.Size(2456, 486);
            this.dGV_Mahasiswa.TabIndex = 8;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(551, 188);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(161, 39);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(1594, 184);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(152, 43);
            this.btn_Submit.TabIndex = 16;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tB_KotaAsal
            // 
            this.tB_KotaAsal.Location = new System.Drawing.Point(1594, 129);
            this.tB_KotaAsal.Name = "tB_KotaAsal";
            this.tB_KotaAsal.Size = new System.Drawing.Size(176, 31);
            this.tB_KotaAsal.TabIndex = 15;
            // 
            // tB_Nama
            // 
            this.tB_Nama.Location = new System.Drawing.Point(1594, 81);
            this.tB_Nama.Name = "tB_Nama";
            this.tB_Nama.Size = new System.Drawing.Size(176, 31);
            this.tB_Nama.TabIndex = 14;
            // 
            // tB_NIM
            // 
            this.tB_NIM.Location = new System.Drawing.Point(1594, 35);
            this.tB_NIM.Name = "tB_NIM";
            this.tB_NIM.Size = new System.Drawing.Size(176, 31);
            this.tB_NIM.TabIndex = 13;
            // 
            // lb_KotaAsal
            // 
            this.lb_KotaAsal.AutoSize = true;
            this.lb_KotaAsal.Location = new System.Drawing.Point(1462, 132);
            this.lb_KotaAsal.Name = "lb_KotaAsal";
            this.lb_KotaAsal.Size = new System.Drawing.Size(104, 25);
            this.lb_KotaAsal.TabIndex = 12;
            this.lb_KotaAsal.Text = "Kota Asal";
            // 
            // lb_Nama
            // 
            this.lb_Nama.AutoSize = true;
            this.lb_Nama.Location = new System.Drawing.Point(1462, 87);
            this.lb_Nama.Name = "lb_Nama";
            this.lb_Nama.Size = new System.Drawing.Size(68, 25);
            this.lb_Nama.TabIndex = 11;
            this.lb_Nama.Text = "Nama";
            // 
            // lb_NIM
            // 
            this.lb_NIM.AutoSize = true;
            this.lb_NIM.Location = new System.Drawing.Point(1462, 41);
            this.lb_NIM.Name = "lb_NIM";
            this.lb_NIM.Size = new System.Drawing.Size(50, 25);
            this.lb_NIM.TabIndex = 10;
            this.lb_NIM.Text = "NIM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2492, 1262);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tB_KotaAsal);
            this.Controls.Add(this.tB_Nama);
            this.Controls.Add(this.tB_NIM);
            this.Controls.Add(this.lb_KotaAsal);
            this.Controls.Add(this.lb_Nama);
            this.Controls.Add(this.lb_NIM);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dGV_Mahasiswa);
            this.Controls.Add(this.dGV_Player);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tB_Database);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Username);
            this.Controls.Add(this.lb_Database);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Mahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Database;
        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.TextBox tB_Database;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.DataGridView dGV_Player;
        private System.Windows.Forms.DataGridView dGV_Mahasiswa;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tB_KotaAsal;
        private System.Windows.Forms.TextBox tB_Nama;
        private System.Windows.Forms.TextBox tB_NIM;
        private System.Windows.Forms.Label lb_KotaAsal;
        private System.Windows.Forms.Label lb_Nama;
        private System.Windows.Forms.Label lb_NIM;
    }
}

