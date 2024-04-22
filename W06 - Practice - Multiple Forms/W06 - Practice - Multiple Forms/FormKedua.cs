using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06___Practice___Multiple_Forms
{
    public partial class FormKedua : Form
    {
        Form1 form;
        string idBaru;

        public FormKedua()
        {
            InitializeComponent();
        }

        public FormKedua(Form _sender)
        {
            InitializeComponent();
            form = (Form1)_sender;
        }

        public void setLabel(string textKu)
        {
            lbl_Hasil.Text = textKu;
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int angka = rnd.Next(0, 50);
            form.setAngkaRandom(angka);
        }

        public void setID(int idProduk)
        {
            idBaru = "00" + idProduk;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            form.MenuBaru(tB_IdProduk.Text, tB_NamaProduk.Text, tB_Harga.Text);
            tB_IdProduk.Text = string.Empty;
            tB_NamaProduk.Text = string.Empty;
            tB_Harga.Text = string.Empty;
            this.Close();
        }
    }
}
