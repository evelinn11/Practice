namespace W06___Practice___Multiple_Forms
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tB_Input = new System.Windows.Forms.TextBox();
            this.lbl_Random = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_Produk = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Produk)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(68, 183);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(103, 35);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(52, 33);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(136, 35);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send To Form Kedua";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tB_Input
            // 
            this.tB_Input.Location = new System.Drawing.Point(52, 7);
            this.tB_Input.Name = "tB_Input";
            this.tB_Input.Size = new System.Drawing.Size(136, 20);
            this.tB_Input.TabIndex = 3;
            // 
            // lbl_Random
            // 
            this.lbl_Random.AutoSize = true;
            this.lbl_Random.Location = new System.Drawing.Point(65, 124);
            this.lbl_Random.Name = "lbl_Random";
            this.lbl_Random.Size = new System.Drawing.Size(87, 13);
            this.lbl_Random.TabIndex = 4;
            this.lbl_Random.Text = "Angka Random: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Random);
            this.panel1.Controls.Add(this.tB_Input);
            this.panel1.Controls.Add(this.btn_Send);
            this.panel1.Controls.Add(this.btn_Open);
            this.panel1.Location = new System.Drawing.Point(423, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 261);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // dGV_Produk
            // 
            this.dGV_Produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Produk.Location = new System.Drawing.Point(17, 24);
            this.dGV_Produk.Name = "dGV_Produk";
            this.dGV_Produk.Size = new System.Drawing.Size(377, 144);
            this.dGV_Produk.TabIndex = 6;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(17, 174);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(73, 31);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(96, 174);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(73, 31);
            this.btn_Remove.TabIndex = 8;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 313);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dGV_Produk);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Produk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tB_Input;
        private System.Windows.Forms.Label lbl_Random;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGV_Produk;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
    }
}

