namespace W06___Practice___Multiple_Forms
{
    partial class FormRemove
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
            this.btn_Remove = new System.Windows.Forms.Button();
            this.tB_HargaR = new System.Windows.Forms.TextBox();
            this.tB_IdProdukR = new System.Windows.Forms.TextBox();
            this.lb_HargaR = new System.Windows.Forms.Label();
            this.lb_NamaProdukR = new System.Windows.Forms.Label();
            this.lb_IdProdukR = new System.Windows.Forms.Label();
            this.cBox_Produk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(147, 135);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(69, 26);
            this.btn_Remove.TabIndex = 16;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // tB_HargaR
            // 
            this.tB_HargaR.Enabled = false;
            this.tB_HargaR.Location = new System.Drawing.Point(130, 100);
            this.tB_HargaR.Name = "tB_HargaR";
            this.tB_HargaR.Size = new System.Drawing.Size(110, 20);
            this.tB_HargaR.TabIndex = 15;
            // 
            // tB_IdProdukR
            // 
            this.tB_IdProdukR.Enabled = false;
            this.tB_IdProdukR.Location = new System.Drawing.Point(130, 65);
            this.tB_IdProdukR.Name = "tB_IdProdukR";
            this.tB_IdProdukR.Size = new System.Drawing.Size(110, 20);
            this.tB_IdProdukR.TabIndex = 13;
            // 
            // lb_HargaR
            // 
            this.lb_HargaR.AutoSize = true;
            this.lb_HargaR.Location = new System.Drawing.Point(76, 103);
            this.lb_HargaR.Name = "lb_HargaR";
            this.lb_HargaR.Size = new System.Drawing.Size(39, 13);
            this.lb_HargaR.TabIndex = 12;
            this.lb_HargaR.Text = "Harga:";
            // 
            // lb_NamaProdukR
            // 
            this.lb_NamaProdukR.AutoSize = true;
            this.lb_NamaProdukR.Location = new System.Drawing.Point(40, 33);
            this.lb_NamaProdukR.Name = "lb_NamaProdukR";
            this.lb_NamaProdukR.Size = new System.Drawing.Size(75, 13);
            this.lb_NamaProdukR.TabIndex = 11;
            this.lb_NamaProdukR.Text = "Nama Produk:";
            // 
            // lb_IdProdukR
            // 
            this.lb_IdProdukR.AutoSize = true;
            this.lb_IdProdukR.Location = new System.Drawing.Point(57, 68);
            this.lb_IdProdukR.Name = "lb_IdProdukR";
            this.lb_IdProdukR.Size = new System.Drawing.Size(58, 13);
            this.lb_IdProdukR.TabIndex = 10;
            this.lb_IdProdukR.Text = "ID Produk:";
            // 
            // cBox_Produk
            // 
            this.cBox_Produk.FormattingEnabled = true;
            this.cBox_Produk.Location = new System.Drawing.Point(131, 30);
            this.cBox_Produk.Name = "cBox_Produk";
            this.cBox_Produk.Size = new System.Drawing.Size(109, 21);
            this.cBox_Produk.TabIndex = 17;
            this.cBox_Produk.SelectedIndexChanged += new System.EventHandler(this.cBox_Produk_SelectedIndexChanged);
            // 
            // FormRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 218);
            this.Controls.Add(this.cBox_Produk);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.tB_HargaR);
            this.Controls.Add(this.tB_IdProdukR);
            this.Controls.Add(this.lb_HargaR);
            this.Controls.Add(this.lb_NamaProdukR);
            this.Controls.Add(this.lb_IdProdukR);
            this.Name = "FormRemove";
            this.Text = "FormRemove";
            this.Load += new System.EventHandler(this.FormRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox tB_HargaR;
        private System.Windows.Forms.TextBox tB_IdProdukR;
        private System.Windows.Forms.Label lb_HargaR;
        private System.Windows.Forms.Label lb_NamaProdukR;
        private System.Windows.Forms.Label lb_IdProdukR;
        private System.Windows.Forms.ComboBox cBox_Produk;
    }
}