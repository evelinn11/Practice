namespace W07___Practice___Picture_Box
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
            this.pBox_Hewan1 = new System.Windows.Forms.PictureBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Hewan1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_Hewan1
            // 
            this.pBox_Hewan1.Location = new System.Drawing.Point(156, 48);
            this.pBox_Hewan1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_Hewan1.Name = "pBox_Hewan1";
            this.pBox_Hewan1.Size = new System.Drawing.Size(408, 307);
            this.pBox_Hewan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Hewan1.TabIndex = 0;
            this.pBox_Hewan1.TabStop = false;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(616, 187);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(94, 54);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "NEXT";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(30, 187);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(94, 54);
            this.btn_Prev.TabIndex = 2;
            this.btn_Prev.Text = "PREV";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(318, 381);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(84, 23);
            this.btn_Change.TabIndex = 3;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 420);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.pBox_Hewan1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Hewan1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_Hewan1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Change;
    }
}

