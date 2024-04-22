namespace W02___Practice___Button
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
            this.lb_Nama = new System.Windows.Forms.Label();
            this.lb_Jumlah = new System.Windows.Forms.Label();
            this.lb_Huruf = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.lb_Hasil = new System.Windows.Forms.Label();
            this.tB_Input = new System.Windows.Forms.TextBox();
            this.cB_Bold = new System.Windows.Forms.CheckBox();
            this.cB_Italic = new System.Windows.Forms.CheckBox();
            this.cB_Underline = new System.Windows.Forms.CheckBox();
            this.rBtn_Hilang = new System.Windows.Forms.RadioButton();
            this.rBtn_Muncul = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lb_Nama
            // 
            this.lb_Nama.AutoSize = true;
            this.lb_Nama.Location = new System.Drawing.Point(31, 29);
            this.lb_Nama.Name = "lb_Nama";
            this.lb_Nama.Size = new System.Drawing.Size(35, 13);
            this.lb_Nama.TabIndex = 0;
            this.lb_Nama.Text = "Nama";
            // 
            // lb_Jumlah
            // 
            this.lb_Jumlah.AutoSize = true;
            this.lb_Jumlah.Location = new System.Drawing.Point(31, 93);
            this.lb_Jumlah.Name = "lb_Jumlah";
            this.lb_Jumlah.Size = new System.Drawing.Size(69, 13);
            this.lb_Jumlah.TabIndex = 1;
            this.lb_Jumlah.Text = "Jumlah Huruf";
            // 
            // lb_Huruf
            // 
            this.lb_Huruf.AutoSize = true;
            this.lb_Huruf.Location = new System.Drawing.Point(129, 93);
            this.lb_Huruf.Name = "lb_Huruf";
            this.lb_Huruf.Size = new System.Drawing.Size(13, 13);
            this.lb_Huruf.TabIndex = 2;
            this.lb_Huruf.Text = "0";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(212, 24);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 3;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // lb_Hasil
            // 
            this.lb_Hasil.AutoSize = true;
            this.lb_Hasil.Location = new System.Drawing.Point(107, 59);
            this.lb_Hasil.Name = "lb_Hasil";
            this.lb_Hasil.Size = new System.Drawing.Size(10, 13);
            this.lb_Hasil.TabIndex = 4;
            this.lb_Hasil.Text = "-";
            // 
            // tB_Input
            // 
            this.tB_Input.Location = new System.Drawing.Point(86, 26);
            this.tB_Input.Name = "tB_Input";
            this.tB_Input.Size = new System.Drawing.Size(100, 20);
            this.tB_Input.TabIndex = 5;
            // 
            // cB_Bold
            // 
            this.cB_Bold.AutoSize = true;
            this.cB_Bold.Location = new System.Drawing.Point(317, 26);
            this.cB_Bold.Name = "cB_Bold";
            this.cB_Bold.Size = new System.Drawing.Size(47, 17);
            this.cB_Bold.TabIndex = 6;
            this.cB_Bold.Text = "Bold";
            this.cB_Bold.UseVisualStyleBackColor = true;
            // 
            // cB_Italic
            // 
            this.cB_Italic.AutoSize = true;
            this.cB_Italic.Location = new System.Drawing.Point(317, 49);
            this.cB_Italic.Name = "cB_Italic";
            this.cB_Italic.Size = new System.Drawing.Size(48, 17);
            this.cB_Italic.TabIndex = 7;
            this.cB_Italic.Text = "Italic";
            this.cB_Italic.UseVisualStyleBackColor = true;
            // 
            // cB_Underline
            // 
            this.cB_Underline.AutoSize = true;
            this.cB_Underline.Location = new System.Drawing.Point(317, 72);
            this.cB_Underline.Name = "cB_Underline";
            this.cB_Underline.Size = new System.Drawing.Size(71, 17);
            this.cB_Underline.TabIndex = 8;
            this.cB_Underline.Text = "Underline";
            this.cB_Underline.UseVisualStyleBackColor = true;
            // 
            // rBtn_Hilang
            // 
            this.rBtn_Hilang.AutoSize = true;
            this.rBtn_Hilang.Location = new System.Drawing.Point(45, 146);
            this.rBtn_Hilang.Name = "rBtn_Hilang";
            this.rBtn_Hilang.Size = new System.Drawing.Size(55, 17);
            this.rBtn_Hilang.TabIndex = 9;
            this.rBtn_Hilang.TabStop = true;
            this.rBtn_Hilang.Text = "Hilang";
            this.rBtn_Hilang.UseVisualStyleBackColor = true;
            this.rBtn_Hilang.CheckedChanged += new System.EventHandler(this.rBtn_Hilang_CheckedChanged);
            // 
            // rBtn_Muncul
            // 
            this.rBtn_Muncul.AutoSize = true;
            this.rBtn_Muncul.Location = new System.Drawing.Point(161, 146);
            this.rBtn_Muncul.Name = "rBtn_Muncul";
            this.rBtn_Muncul.Size = new System.Drawing.Size(60, 17);
            this.rBtn_Muncul.TabIndex = 10;
            this.rBtn_Muncul.TabStop = true;
            this.rBtn_Muncul.Text = "Muncul";
            this.rBtn_Muncul.UseVisualStyleBackColor = true;
            this.rBtn_Muncul.CheckedChanged += new System.EventHandler(this.rBtn_Muncul_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtn_Muncul);
            this.Controls.Add(this.rBtn_Hilang);
            this.Controls.Add(this.cB_Underline);
            this.Controls.Add(this.cB_Italic);
            this.Controls.Add(this.cB_Bold);
            this.Controls.Add(this.tB_Input);
            this.Controls.Add(this.lb_Hasil);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.lb_Huruf);
            this.Controls.Add(this.lb_Jumlah);
            this.Controls.Add(this.lb_Nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nama;
        private System.Windows.Forms.Label lb_Jumlah;
        private System.Windows.Forms.Label lb_Huruf;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label lb_Hasil;
        private System.Windows.Forms.TextBox tB_Input;
        private System.Windows.Forms.CheckBox cB_Bold;
        private System.Windows.Forms.CheckBox cB_Italic;
        private System.Windows.Forms.CheckBox cB_Underline;
        private System.Windows.Forms.RadioButton rBtn_Hilang;
        private System.Windows.Forms.RadioButton rBtn_Muncul;
    }
}

