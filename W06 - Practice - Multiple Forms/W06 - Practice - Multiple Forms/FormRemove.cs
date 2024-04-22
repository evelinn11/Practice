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
    public partial class FormRemove : Form
    {
        Form1 form;
        DataTable dtProdukAda;
        int getIndex;

        public FormRemove()
        {
            InitializeComponent();
        }

        public FormRemove(Form _sender)
        {
            InitializeComponent();
            form = (Form1)_sender;
        }


        public void AmbilDataTable(DataTable data)
        {
            dtProdukAda = data;
        }

        private void FormRemove_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dtProdukAda.Rows.Count; i++)
            {
                cBox_Produk.Items.Add(dtProdukAda.Rows[i][1]);
            }
        }

        private void cBox_Produk_SelectedIndexChanged(object sender, EventArgs e)
        {
            getIndex = cBox_Produk.SelectedIndex;
            tB_IdProdukR.Text = dtProdukAda.Rows[getIndex][0].ToString();
            tB_HargaR.Text = dtProdukAda.Rows[getIndex][2].ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            form.RemoveProduk(tB_IdProdukR.Text);
            this.Close();
        }
    }
}
