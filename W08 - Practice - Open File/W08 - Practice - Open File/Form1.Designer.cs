namespace W08___Practice___Open_File
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
            this.btn_Baca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Baca
            // 
            this.btn_Baca.Location = new System.Drawing.Point(147, 86);
            this.btn_Baca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Baca.Name = "btn_Baca";
            this.btn_Baca.Size = new System.Drawing.Size(88, 37);
            this.btn_Baca.TabIndex = 0;
            this.btn_Baca.Text = "Baca File";
            this.btn_Baca.UseVisualStyleBackColor = true;
            this.btn_Baca.Click += new System.EventHandler(this.btn_Baca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.btn_Baca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Baca;
    }
}

