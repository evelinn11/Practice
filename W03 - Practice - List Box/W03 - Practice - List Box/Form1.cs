using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03___Practice___List_Box
{
    public partial class Form1 : Form
    {
        DataTable dtMakanan = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            listB_Makanan.Items.Add(tB_Makanan.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listB_Makanan.Items.Clear();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            listB_Makanan.Items.Remove(listB_Makanan.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtMakanan.Columns.Add("ID Makanan");
            dtMakanan.Columns.Add("Nama Makanan");
            dtMakanan.Columns.Add("Harga Makanan");
            dtMakanan.Rows.Add("A001", "Nasi Goreng", "15000");
            dtMakanan.Rows.Add("A002", "Nasi Kucing", "20000");
            dtMakanan.Rows.Add("A003", "Nasi Pecel", "25000");
            dtMakanan.Rows.Add("A004", "Nasi Kuning", "8000");
            dtMakanan.Rows.Add("A005", "Nasi Campur", "30000");

            listB_Makanan.DataSource = dtMakanan;
            //listB_Makanan.ValueMember = "ID Makanan";
            listB_Makanan.DisplayMember = "Nama Makanan";
        }

        private void btn_Pilih_Click(object sender, EventArgs e)
        {
            int index = listB_Makanan.SelectedIndex;
            string idmakan = dtMakanan.Rows[index][0].ToString();
            string namaMakan = dtMakanan.Rows[index][1].ToString();
            string hargaMakan = dtMakanan.Rows[index][2].ToString();
            MessageBox.Show($"{idmakan} - {namaMakan} - Rp. {hargaMakan}");
        }
    }
}
