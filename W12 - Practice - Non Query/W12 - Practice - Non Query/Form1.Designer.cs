namespace W12___Practice___Non_Query
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
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.tB_Nama = new System.Windows.Forms.TextBox();
            this.tB_NIM = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Nama = new System.Windows.Forms.Label();
            this.lb_NIM = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dGV_Student = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_UNIM = new System.Windows.Forms.TextBox();
            this.tB_UNama = new System.Windows.Forms.TextBox();
            this.tb_UID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(153, 71);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(185, 31);
            this.tB_ID.TabIndex = 0;
            // 
            // tB_Nama
            // 
            this.tB_Nama.Location = new System.Drawing.Point(153, 121);
            this.tB_Nama.Name = "tB_Nama";
            this.tB_Nama.Size = new System.Drawing.Size(185, 31);
            this.tB_Nama.TabIndex = 1;
            // 
            // tB_NIM
            // 
            this.tB_NIM.Location = new System.Drawing.Point(153, 177);
            this.tB_NIM.Name = "tB_NIM";
            this.tB_NIM.Size = new System.Drawing.Size(185, 31);
            this.tB_NIM.TabIndex = 2;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(64, 74);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(32, 25);
            this.lb_ID.TabIndex = 3;
            this.lb_ID.Text = "ID";
            // 
            // lb_Nama
            // 
            this.lb_Nama.AutoSize = true;
            this.lb_Nama.Location = new System.Drawing.Point(64, 124);
            this.lb_Nama.Name = "lb_Nama";
            this.lb_Nama.Size = new System.Drawing.Size(68, 25);
            this.lb_Nama.TabIndex = 4;
            this.lb_Nama.Text = "Nama";
            // 
            // lb_NIM
            // 
            this.lb_NIM.AutoSize = true;
            this.lb_NIM.Location = new System.Drawing.Point(64, 177);
            this.lb_NIM.Name = "lb_NIM";
            this.lb_NIM.Size = new System.Drawing.Size(50, 25);
            this.lb_NIM.TabIndex = 5;
            this.lb_NIM.Text = "NIM";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(153, 242);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(181, 78);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dGV_Student
            // 
            this.dGV_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Student.Location = new System.Drawing.Point(501, 48);
            this.dGV_Student.Name = "dGV_Student";
            this.dGV_Student.RowHeadersWidth = 82;
            this.dGV_Student.RowTemplate.Height = 33;
            this.dGV_Student.Size = new System.Drawing.Size(1341, 793);
            this.dGV_Student.TabIndex = 7;
            this.dGV_Student.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Student_CellDoubleClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(153, 607);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(181, 78);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // tb_UNIM
            // 
            this.tb_UNIM.Location = new System.Drawing.Point(153, 542);
            this.tb_UNIM.Name = "tb_UNIM";
            this.tb_UNIM.Size = new System.Drawing.Size(185, 31);
            this.tb_UNIM.TabIndex = 10;
            // 
            // tB_UNama
            // 
            this.tB_UNama.Location = new System.Drawing.Point(153, 486);
            this.tB_UNama.Name = "tB_UNama";
            this.tB_UNama.Size = new System.Drawing.Size(185, 31);
            this.tB_UNama.TabIndex = 9;
            // 
            // tb_UID
            // 
            this.tb_UID.Enabled = false;
            this.tb_UID.Location = new System.Drawing.Point(153, 436);
            this.tb_UID.Name = "tb_UID";
            this.tb_UID.Size = new System.Drawing.Size(185, 31);
            this.tb_UID.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1999, 983);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_UNIM);
            this.Controls.Add(this.tB_UNama);
            this.Controls.Add(this.tb_UID);
            this.Controls.Add(this.dGV_Student);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.lb_NIM);
            this.Controls.Add(this.lb_Nama);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.tB_NIM);
            this.Controls.Add(this.tB_Nama);
            this.Controls.Add(this.tB_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.TextBox tB_Nama;
        private System.Windows.Forms.TextBox tB_NIM;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_Nama;
        private System.Windows.Forms.Label lb_NIM;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dGV_Student;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_UNIM;
        private System.Windows.Forms.TextBox tB_UNama;
        private System.Windows.Forms.TextBox tb_UID;
    }
}

