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
    public partial class Form1 : Form
    {
        FormRemove formR;
        FormKedua form;
        DataTable dtProduk;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            //form = new FormKedua(this);
            ////form.ShowDialog();
            //form.Show();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            form.setLabel(tB_Input.Text);
        }

        public void setAngkaRandom(int _angka)
        {
            lbl_Random.Text = "Angka Random: " + _angka;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtProduk = new DataTable();
            dtProduk.Columns.Add("ID");
            dtProduk.Columns.Add("Nama Produk");
            dtProduk.Columns.Add("Harga");
            dtProduk.Rows.Add("001", "Nasi Goreng", "20000");
            dtProduk.Rows.Add("002", "Ayam Geprek", "15000");
            dtProduk.Rows.Add("003", "Es Teh Manis", "10000");
            dGV_Produk.DataSource = dtProduk;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            form = new FormKedua(this);
            //form.setID(Convert.ToInt32(dtProduk.Rows[dtProduk.Rows.Count - 1][0]));
            form.Show();
        }

        public void MenuBaru(string id, string nama, string harga)
        {
            dtProduk.Rows.Add(id, nama, harga);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            formR = new FormRemove(this);
            formR.AmbilDataTable(dtProduk);
            formR.Show();
        }

        public void RemoveProduk(string id)
        {
            int row = 0;
            for(int i = 0; i < dtProduk.Rows.Count; i++)
            {
                if (dtProduk.Rows[i][0].ToString() == id)
                {
                    row = i;
                    break;
                }
            }
            dtProduk.Rows.RemoveAt(row);
        }
    }
}
