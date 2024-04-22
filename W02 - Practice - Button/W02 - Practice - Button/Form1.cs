using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02___Practice___Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rBtn_Hilang_CheckedChanged(object sender, EventArgs e)
        {
            lb_Hasil.Visible = false;
        }

        private void rBtn_Muncul_CheckedChanged(object sender, EventArgs e)
        {
            lb_Hasil.Visible = true;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            int panjangHuruf = tB_Input.Text.Length;
            lb_Hasil.Text = tB_Input.Text;
            lb_Huruf.Text = Convert.ToString(panjangHuruf);

            //cara manual
            if (cB_Bold.Checked == true)
            {
                lb_Hasil.Font = new Font(this.Font, FontStyle.Bold);
            }
            if (cB_Italic.Checked == true)
            {
                lb_Hasil.Font = new Font(this.Font, FontStyle.Italic);
            }
            if (cB_Underline.Checked == true)
            {
                lb_Hasil.Font = new Font(this.Font, FontStyle.Underline);
            }
            if (cB_Bold.Checked == true && cB_Italic.Checked == true)
            {
                lb_Hasil.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (cB_Italic.Checked == true && cB_Underline.Checked == true)
            {
                lb_Hasil.Font = new Font(this.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (cB_Bold.Checked == true && cB_Underline.Checked == true)
            {
                lb_Hasil.Font = new Font(this.Font, FontStyle.Underline | FontStyle.Bold);
            }
            if (cB_Bold.Checked == true && cB_Italic.Checked == true && cB_Underline.Checked == true)
            {
                lb_Hasil.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }

            //cara cepat
            //Font fnt = new Font(lb_Hasil.Font.FontFamily, lb_Hasil.Font.Size, FontStyle.Regular);
            //if (cB_Bold.Checked == true)
            //{
            //    fnt = new Font(lb_Hasil.Font, fnt.Style | FontStyle.Bold);
            //}
            //if (cB_Italic.Checked == true)
            //{
            //    fnt = new Font(lb_Hasil.Font, fnt.Style | FontStyle.Italic);
            //}
            //if (cB_Underline.Checked == true)
            //{
            //    fnt = new Font(lb_Hasil.Font, fnt.Style | FontStyle.Underline);
            //}
        }
    }
}
