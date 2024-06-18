using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W12___Practice___Non_Query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtStudent;
        string sqlQuery;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection($"server=localhost;uid=root;pwd=isbmantap;database=premier_league");
            dtStudent = new DataTable();
            sqlQuery = "SELECT * FROM student";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtStudent);
            dGV_Student.DataSource = dtStudent;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            //DATE di SQL = YYYY-MM-DD
            //DATETIME.NOW YYYY-MM-DD HH:MM:SS
            //ambil tahun Date.Time.Now.Year
            string birthdate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-"+DateTime.Now.Day.ToString();
            bool kembar = false;
            for (int i = 0; i < dtStudent.Rows.Count; i++)
            {
                if (tB_NIM.Text == dtStudent.Rows[i][3].ToString())
                {
                    kembar = true;
                }
            }

            if (kembar)
            {
                MessageBox.Show("NIM tidak boleh kembar");
            }
            else
            {

                dtStudent = new DataTable();
                //sqlQuery = $"INSERT INTO student VALUES ('{tB_ID.Text}', '{tB_Nama.Text}', '2024-5-15', '{tB_NIM.Text}')";
                sqlConnect.Open();
                sqlCommand = sqlConnect.CreateCommand();
                sqlQuery = $"INSERT INTO student VALUES (@id, @name, @birthday, @nim)";
                sqlCommand.CommandText = sqlQuery;
                sqlCommand.Parameters.AddWithValue("@id", tB_ID.Text);
                sqlCommand.Parameters.AddWithValue("@name", tB_Nama.Text);
                sqlCommand.Parameters.AddWithValue("@birthday", birthdate);
                sqlCommand.Parameters.AddWithValue("@nim", tB_NIM.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                sqlQuery = "SELECT * FROM student";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtStudent);
                dGV_Student.DataSource = dtStudent;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            dtStudent = new DataTable();
            sqlQuery = $"UPDATE student SET Student_Name = '{tB_UNama.Text}', student_nim = '{tb_UNIM.Text}' WHERE ID_Student = {tb_UID.Text}";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            sqlQuery = "SELECT * FROM student";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtStudent);
            dGV_Student.DataSource = dtStudent;
        }

        private void dGV_Student_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGV_Student.CurrentRow.Index;
            tb_UID.Text = dtStudent.Rows[index][0].ToString();
            tB_UNama.Text = dtStudent.Rows[index][1].ToString();
            tb_UNIM.Text = dtStudent.Rows[index][3].ToString();
        }
    }
}
