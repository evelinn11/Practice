namespace W04___Practice___Data_Grid_View
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
            this.btn_Message = new System.Windows.Forms.Button();
            this.tB_Angka = new System.Windows.Forms.TextBox();
            this.lb_Angka = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_NIM = new System.Windows.Forms.Label();
            this.lb_Prodi = new System.Windows.Forms.Label();
            this.tB_NIM = new System.Windows.Forms.TextBox();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.tB_Prodi = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Message
            // 
            this.btn_Message.Location = new System.Drawing.Point(18, 94);
            this.btn_Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Message.Name = "btn_Message";
            this.btn_Message.Size = new System.Drawing.Size(109, 76);
            this.btn_Message.TabIndex = 0;
            this.btn_Message.Text = "Check";
            this.btn_Message.UseVisualStyleBackColor = true;
            this.btn_Message.Click += new System.EventHandler(this.btn_Message_Click);
            // 
            // tB_Angka
            // 
            this.tB_Angka.Location = new System.Drawing.Point(18, 57);
            this.tB_Angka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Angka.Name = "tB_Angka";
            this.tB_Angka.Size = new System.Drawing.Size(110, 20);
            this.tB_Angka.TabIndex = 1;
            // 
            // lb_Angka
            // 
            this.lb_Angka.AutoSize = true;
            this.lb_Angka.Location = new System.Drawing.Point(16, 31);
            this.lb_Angka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Angka.Name = "lb_Angka";
            this.lb_Angka.Size = new System.Drawing.Size(38, 13);
            this.lb_Angka.TabIndex = 2;
            this.lb_Angka.Text = "Angka";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(172, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(349, 221);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(586, 123);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(35, 13);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "Name";
            // 
            // lb_NIM
            // 
            this.lb_NIM.AutoSize = true;
            this.lb_NIM.Location = new System.Drawing.Point(586, 87);
            this.lb_NIM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NIM.Name = "lb_NIM";
            this.lb_NIM.Size = new System.Drawing.Size(27, 13);
            this.lb_NIM.TabIndex = 4;
            this.lb_NIM.Text = "NIM";
            // 
            // lb_Prodi
            // 
            this.lb_Prodi.AutoSize = true;
            this.lb_Prodi.Location = new System.Drawing.Point(586, 155);
            this.lb_Prodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Prodi.Name = "lb_Prodi";
            this.lb_Prodi.Size = new System.Drawing.Size(31, 13);
            this.lb_Prodi.TabIndex = 5;
            this.lb_Prodi.Text = "Prodi";
            // 
            // tB_NIM
            // 
            this.tB_NIM.Location = new System.Drawing.Point(626, 87);
            this.tB_NIM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_NIM.Name = "tB_NIM";
            this.tB_NIM.Size = new System.Drawing.Size(110, 20);
            this.tB_NIM.TabIndex = 6;
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(626, 121);
            this.tB_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(110, 20);
            this.tB_Name.TabIndex = 7;
            // 
            // tB_Prodi
            // 
            this.tB_Prodi.Location = new System.Drawing.Point(626, 155);
            this.tB_Prodi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Prodi.Name = "tB_Prodi";
            this.tB_Prodi.Size = new System.Drawing.Size(110, 20);
            this.tB_Prodi.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(589, 185);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 29);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(697, 185);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 29);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(282, 286);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(96, 29);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 353);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tB_Prodi);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.tB_NIM);
            this.Controls.Add(this.lb_Prodi);
            this.Controls.Add(this.lb_NIM);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_Angka);
            this.Controls.Add(this.tB_Angka);
            this.Controls.Add(this.btn_Message);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Message;
        private System.Windows.Forms.TextBox tB_Angka;
        private System.Windows.Forms.Label lb_Angka;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_NIM;
        private System.Windows.Forms.Label lb_Prodi;
        private System.Windows.Forms.TextBox tB_NIM;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.TextBox tB_Prodi;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
    }
}

