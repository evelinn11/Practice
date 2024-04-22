namespace W03___Practice___List_Box
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listB_Makanan = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Makanan = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Pilih = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Warung",
            "Restoran",
            "Pasar",
            "Rumah",
            "Hotel"});
            this.comboBox1.Location = new System.Drawing.Point(577, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listB_Makanan
            // 
            this.listB_Makanan.FormattingEnabled = true;
            this.listB_Makanan.Items.AddRange(new object[] {
            "Nasi Goreng",
            "Nasi Kuning",
            "Telur Ceplok",
            "Ramyeon",
            "Tteokbokki"});
            this.listB_Makanan.Location = new System.Drawing.Point(29, 94);
            this.listB_Makanan.Name = "listB_Makanan";
            this.listB_Makanan.Size = new System.Drawing.Size(115, 95);
            this.listB_Makanan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Makanan";
            // 
            // tB_Makanan
            // 
            this.tB_Makanan.Location = new System.Drawing.Point(115, 21);
            this.tB_Makanan.Name = "tB_Makanan";
            this.tB_Makanan.Size = new System.Drawing.Size(107, 20);
            this.tB_Makanan.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(130, 47);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(29, 195);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(115, 195);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Pilih
            // 
            this.btn_Pilih.Location = new System.Drawing.Point(165, 153);
            this.btn_Pilih.Name = "btn_Pilih";
            this.btn_Pilih.Size = new System.Drawing.Size(75, 23);
            this.btn_Pilih.TabIndex = 7;
            this.btn_Pilih.Text = "Pilih";
            this.btn_Pilih.UseVisualStyleBackColor = true;
            this.btn_Pilih.Click += new System.EventHandler(this.btn_Pilih_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Pilih);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tB_Makanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listB_Makanan);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listB_Makanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Makanan;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Pilih;
    }
}

