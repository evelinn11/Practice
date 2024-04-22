using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04___Practice___Data_Grid_View
{
    public partial class Form1 : Form
    {
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Message_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Error detected", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            //MessageBox.Show(dr.ToString());

            DialogResult dr = MessageBox.Show("Apakah ini prima?", "Test Your Math!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            bool cek = false;
            int input = Convert.ToInt32(tB_Angka.Text);
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                cek = true;
            }

            if (cek && dr == DialogResult.Yes || (cek == false && dr == DialogResult.No))
            {
                MessageBox.Show("hore benar :D");
            }
            else
            {
                MessageBox.Show("yah salah :(");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("NIM");
            dt.Columns.Add("Name");
            dt.Columns.Add("Prodi");
            dt.Rows.Add("0706022310021", "Evelin", "ISB");
            dt.Rows.Add("0706022310019", "Celin", "ISB");
            dt.Rows.Add("0706022310002", "Felicia", "ISB");
            dt.Rows.Add("0706022310001", "Evelyn", "ISB");
            dt.Rows.Add("0706022310006", "Angeline", "ISB");
            dt.Rows.Add("0706022310033", "Amira", "ISB");
            dataGridView1.DataSource = dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool found = false;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i][0].ToString() == tB_NIM.Text)
            //    {
            //        found = true;
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    dt.Rows.Add(tB_NIM.Text, tB_Name.Text, tB_Prodi.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Error detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == tB_NIM.Text)
                {
                    found = true; 
                    break;
                }
            }

            if (!found)
            {
                dt.Rows.Add(tB_NIM.Text, tB_Name.Text, tB_Prodi.Text);

            }
            else
            {
                MessageBox.Show("Error detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tB_NIM.Clear();
            tB_Name.Clear();
            tB_Prodi.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dataGridView1.CurrentRow;
            MessageBox.Show("NIM : " + dgvr.Cells[0].Value.ToString() + ". Name: " + dgvr.Cells[1].Value.ToString() + ". Prodi: " + dgvr.Cells[2].Value.ToString());
        }

        int indexNIM;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dataGridView1.CurrentRow;
            tB_NIM.Enabled = false;
            btn_Add.Enabled = false;
            btn_Update.Enabled = true;

            tB_NIM.Text = dgvr.Cells[0].Value.ToString();
            tB_Name.Text = dgvr.Cells[1].Value.ToString();
            tB_Prodi.Text = dgvr.Cells[2].Value.ToString();

            indexNIM = dgvr.Cells[0].ColumnIndex;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Cells[indexNIM].Value.ToString() == tB_NIM.Text)
                {
                    dgvr.Cells[1].Value = tB_Name.Text;
                    dgvr.Cells[2].Value = tB_Prodi.Text;
                }
            }
            tB_NIM.Clear();
            tB_Name.Clear();
            tB_Prodi.Clear();
            tB_NIM.Enabled = true;
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dataGridView1.CurrentRow;

            dataGridView1.Rows.Remove(dgvr);

        }
    }
}
