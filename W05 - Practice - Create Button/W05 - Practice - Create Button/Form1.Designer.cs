namespace W05___Practice___Create_Button
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
            this.tBox_Create = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.tBox_Remove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBox_Create
            // 
            this.tBox_Create.Location = new System.Drawing.Point(284, 67);
            this.tBox_Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_Create.Name = "tBox_Create";
            this.tBox_Create.Size = new System.Drawing.Size(94, 20);
            this.tBox_Create.TabIndex = 0;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(284, 93);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(82, 37);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(284, 174);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(82, 37);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // tBox_Remove
            // 
            this.tBox_Remove.Location = new System.Drawing.Point(284, 148);
            this.tBox_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_Remove.Name = "tBox_Remove";
            this.tBox_Remove.Size = new System.Drawing.Size(94, 20);
            this.tBox_Remove.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 389);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.tBox_Remove);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tBox_Create);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_Create;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox tBox_Remove;
    }
}

