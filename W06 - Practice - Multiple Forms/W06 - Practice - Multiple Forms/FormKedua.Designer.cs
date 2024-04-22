namespace W06___Practice___Multiple_Forms
{
    partial class FormKedua
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
            this.lbl_Hasil = new System.Windows.Forms.Label();
            this.btn_Random = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_IdProduk = new System.Windows.Forms.Label();
            this.lbl_NamaProduk = new System.Windows.Forms.Label();
            this.lb_Harga = new System.Windows.Forms.Label();
            this.tB_IdProduk = new System.Windows.Forms.TextBox();
            this.tB_NamaProduk = new System.Windows.Forms.TextBox();
            this.tB_Harga = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Hasil
            // 
            this.lbl_Hasil.AutoSize = true;
            this.lbl_Hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasil.Location = new System.Drawing.Point(57, 25);
            this.lbl_Hasil.Name = "lbl_Hasil";
            this.lbl_Hasil.Size = new System.Drawing.Size(56, 24);
            this.lbl_Hasil.TabIndex = 0;
            this.lbl_Hasil.Text = "Hasil";
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(48, 83);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(80, 33);
            this.btn_Random.TabIndex = 1;
            this.btn_Random.Text = "Random";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Random);
            this.panel1.Controls.Add(this.lbl_Hasil);
            this.panel1.Location = new System.Drawing.Point(297, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 178);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lb_IdProduk
            // 
            this.lb_IdProduk.AutoSize = true;
            this.lb_IdProduk.Location = new System.Drawing.Point(50, 59);
            this.lb_IdProduk.Name = "lb_IdProduk";
            this.lb_IdProduk.Size = new System.Drawing.Size(58, 13);
            this.lb_IdProduk.TabIndex = 3;
            this.lb_IdProduk.Text = "ID Produk:";
            // 
            // lbl_NamaProduk
            // 
            this.lbl_NamaProduk.AutoSize = true;
            this.lbl_NamaProduk.Location = new System.Drawing.Point(33, 85);
            this.lbl_NamaProduk.Name = "lbl_NamaProduk";
            this.lbl_NamaProduk.Size = new System.Drawing.Size(75, 13);
            this.lbl_NamaProduk.TabIndex = 4;
            this.lbl_NamaProduk.Text = "Nama Produk:";
            // 
            // lb_Harga
            // 
            this.lb_Harga.AutoSize = true;
            this.lb_Harga.Location = new System.Drawing.Point(69, 110);
            this.lb_Harga.Name = "lb_Harga";
            this.lb_Harga.Size = new System.Drawing.Size(39, 13);
            this.lb_Harga.TabIndex = 5;
            this.lb_Harga.Text = "Harga:";
            // 
            // tB_IdProduk
            // 
            this.tB_IdProduk.Location = new System.Drawing.Point(123, 56);
            this.tB_IdProduk.Name = "tB_IdProduk";
            this.tB_IdProduk.Size = new System.Drawing.Size(110, 20);
            this.tB_IdProduk.TabIndex = 6;
            // 
            // tB_NamaProduk
            // 
            this.tB_NamaProduk.Location = new System.Drawing.Point(123, 82);
            this.tB_NamaProduk.Name = "tB_NamaProduk";
            this.tB_NamaProduk.Size = new System.Drawing.Size(110, 20);
            this.tB_NamaProduk.TabIndex = 7;
            // 
            // tB_Harga
            // 
            this.tB_Harga.Location = new System.Drawing.Point(123, 107);
            this.tB_Harga.Name = "tB_Harga";
            this.tB_Harga.Size = new System.Drawing.Size(110, 20);
            this.tB_Harga.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(140, 142);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(69, 26);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // FormKedua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 217);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tB_Harga);
            this.Controls.Add(this.tB_NamaProduk);
            this.Controls.Add(this.tB_IdProduk);
            this.Controls.Add(this.lb_Harga);
            this.Controls.Add(this.lbl_NamaProduk);
            this.Controls.Add(this.lb_IdProduk);
            this.Controls.Add(this.panel1);
            this.Name = "FormKedua";
            this.Text = "FormKedua";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hasil;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_IdProduk;
        private System.Windows.Forms.Label lbl_NamaProduk;
        private System.Windows.Forms.Label lb_Harga;
        private System.Windows.Forms.TextBox tB_IdProduk;
        private System.Windows.Forms.TextBox tB_NamaProduk;
        private System.Windows.Forms.TextBox tB_Harga;
        private System.Windows.Forms.Button btn_Add;
    }
}