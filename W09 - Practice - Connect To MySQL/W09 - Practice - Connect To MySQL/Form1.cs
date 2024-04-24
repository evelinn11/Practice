using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//tambahin ini utk koneksi ke database
using MySql.Data.MySqlClient;

namespace W09___Practice___Connect_To_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection($"server=10.10.10.136;uid={tB_Username.Text};pwd={tB_Password.Text};database={tB_Database.Text}");
            sqlConnection.Open();
            MessageBox.Show("Yey");
            sqlConnection.Close();

            string sqlQuery = "SELECT * FROM player";
            DataTable dtPlayer = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery,sqlConnection); //query, sqlConnect
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPlayer);
            dGV_Player.DataSource = dtPlayer;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection($"server=10.10.10.136;uid={tB_Username.Text};pwd={tB_Password.Text};database={tB_Database.Text}");
            sqlConnection.Open();
            sqlConnection.Close();
            string sqlQueryMhs = "SELECT * FROM mahasiswa";
            DataTable dtMahasiswa = new DataTable();
            sqlCommand = new MySqlCommand(sqlQueryMhs, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMahasiswa);
            dGV_Mahasiswa.DataSource = dtMahasiswa;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"INSERT INTO mahasiswa VALUES ('{tB_NIM.Text}', '{tB_Nama.Text}', '{tB_KotaAsal.Text}')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery(); //karena bukan query seperti insert update delete
            sqlConnection.Close();
        }
    }
}
