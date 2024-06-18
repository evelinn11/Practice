namespace W14___Practice___Add_Match
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_Team = new System.Windows.Forms.ComboBox();
            this.dGV_Pemain = new System.Windows.Forms.DataGridView();
            this.cBox_Pemain = new System.Windows.Forms.ComboBox();
            this.cBox_Type = new System.Windows.Forms.ComboBox();
            this.tB_Minute = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pemain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pemain :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minute :";
            // 
            // cBox_Team
            // 
            this.cBox_Team.FormattingEnabled = true;
            this.cBox_Team.Location = new System.Drawing.Point(199, 93);
            this.cBox_Team.Name = "cBox_Team";
            this.cBox_Team.Size = new System.Drawing.Size(268, 33);
            this.cBox_Team.TabIndex = 4;
            this.cBox_Team.SelectedIndexChanged += new System.EventHandler(this.cBox_Team_SelectedIndexChanged);
            // 
            // dGV_Pemain
            // 
            this.dGV_Pemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Pemain.Location = new System.Drawing.Point(73, 300);
            this.dGV_Pemain.Name = "dGV_Pemain";
            this.dGV_Pemain.RowHeadersWidth = 82;
            this.dGV_Pemain.RowTemplate.Height = 33;
            this.dGV_Pemain.Size = new System.Drawing.Size(1637, 826);
            this.dGV_Pemain.TabIndex = 5;
            // 
            // cBox_Pemain
            // 
            this.cBox_Pemain.FormattingEnabled = true;
            this.cBox_Pemain.Location = new System.Drawing.Point(199, 143);
            this.cBox_Pemain.Name = "cBox_Pemain";
            this.cBox_Pemain.Size = new System.Drawing.Size(268, 33);
            this.cBox_Pemain.TabIndex = 6;
            this.cBox_Pemain.SelectedIndexChanged += new System.EventHandler(this.cBox_Pemain_SelectedIndexChanged);
            // 
            // cBox_Type
            // 
            this.cBox_Type.FormattingEnabled = true;
            this.cBox_Type.Location = new System.Drawing.Point(199, 193);
            this.cBox_Type.Name = "cBox_Type";
            this.cBox_Type.Size = new System.Drawing.Size(268, 33);
            this.cBox_Type.TabIndex = 7;
            // 
            // tB_Minute
            // 
            this.tB_Minute.Location = new System.Drawing.Point(199, 242);
            this.tB_Minute.Name = "tB_Minute";
            this.tB_Minute.Size = new System.Drawing.Size(267, 31);
            this.tB_Minute.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 1234);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB_Minute);
            this.Controls.Add(this.cBox_Type);
            this.Controls.Add(this.cBox_Pemain);
            this.Controls.Add(this.dGV_Pemain);
            this.Controls.Add(this.cBox_Team);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBox_Team;
        private System.Windows.Forms.DataGridView dGV_Pemain;
        private System.Windows.Forms.ComboBox cBox_Pemain;
        private System.Windows.Forms.ComboBox cBox_Type;
        private System.Windows.Forms.TextBox tB_Minute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

