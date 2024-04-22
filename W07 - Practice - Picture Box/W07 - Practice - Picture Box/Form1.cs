using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace W07___Practice___Picture_Box
{
    public partial class Form1 : Form
    {
        string[] hewanBuas = {"Badak", "Banteng", "Beruang", "Buaya", "Cheetah", "Gorila", "Hiu", "Hyena", "kalajengking", "Komodo", "Piranha", "Rubah", "Serigala", "Singa", "Ular"};
        string[] hewanPeliharaan = { "Anjing", "Bebek", "BurungKakakTua", "Domba", "Ferret", "GuineaPig", "Hamster", "Kambing", "Keledai", "Kelinci", "Koi", "LandakMini", "Merpati", "Otter", "Sapi" };
        int countP;
        int countB;
        string mode = "peliharaan";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBox_Hewan1.Image = new Bitmap("D:\\UC\\Semester 2\\Application Development\\Hewan Peliharaan\\Anjing.jpg");
            countP = 0;
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            //string alamat = "Y:\\Hewan Peliharaan\\Hamster.jpg";
            //pBox_Hewan1.Image = new Bitmap(alamat);
            if (mode == "peliharaan")
            {
                if (countP < 14)
                {
                    countP++;
                    pBox_Hewan1.Image = new Bitmap("D:\\UC\\Semester 2\\Application Development\\Hewan Peliharaan\\" + hewanPeliharaan[countP] + ".jpg");
                }
            }
            else
            {
                if (countB < 14)
                {
                    countB++;
                    pBox_Hewan1.Image = new Bitmap("D:\\UC\\Semester 2\\Application Development\\Hewan Buas\\" + hewanBuas[countB] + ".jpg");
                }
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (mode == "peliharaan")
            {
                if (countP > 0)
                {
                    countP--;
                    pBox_Hewan1.Image = new Bitmap("D:\\UC\\Semester 2\\Application Development\\Hewan Peliharaan\\" + hewanPeliharaan[countP] + ".jpg");
                }
            }
            else
            {
                if (countB > 0)
                {
                    countB--;
                    pBox_Hewan1.Image = new Bitmap("D:\\UC\\Semester 2\\Application Development\\Hewan Buas\\" + hewanBuas[countB] + ".jpg");
                }
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (mode == "peliharaan")
            {
                mode = "buas";
                pBox_Hewan1.Image = new Bitmap("D:\\UC\\Semester 2\\Application Development\\Hewan Buas\\" + hewanBuas[countB] + ".jpg");
            }
            else
            {
                mode = "peliharaan";
                pBox_Hewan1.Image = new Bitmap("D:\\UC\\Semester 2\\Application Development\\Hewan Peliharaan\\" + hewanPeliharaan[countP] + ".jpg");
            }
        }
    }
}
