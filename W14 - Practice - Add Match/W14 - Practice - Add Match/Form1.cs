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

namespace W14___Practice___Add_Match
{
    public partial class Form1 : Form
    {

        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtTeam;
        DataTable dtdmatch;
        DataTable dtPemain;
        DataTable dtType;
        DataTable dtDGV;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtTeam = new DataTable();
            sqlConnection = new MySqlConnection($"server=localhost;port=3308;uid=root;pwd=Twklhrt#12;database=premier_league");
            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);
            cBox_Team.DataSource = dtTeam;
            cBox_Team.ValueMember = "team_id";
            cBox_Team.DisplayMember = "team_name";


            dtType = new DataTable();
            dtType.Columns.Add("type_abv");
            dtType.Columns.Add("type_name");
            dtType.Rows.Add("GO", "Goal");
            dtType.Rows.Add("GW", "Own Goal");
            dtType.Rows.Add("GP", "Goal Penalty");
            dtType.Rows.Add("CY", "Yellow Card");
            dtType.Rows.Add("CR", "Red Card");
            dtType.Rows.Add("PM", "Penalty Miss");
            cBox_Type.DataSource = dtType;
            cBox_Type.ValueMember = "type_abv";
            cBox_Type.DisplayMember = "type_name";

            dtDGV = new DataTable();
            dtDGV.Columns.Add("Minute");
            dtDGV.Columns.Add("Team ID");
            dtDGV.Columns.Add("Player ID");
            dtDGV.Columns.Add("Type");
            dGV_Pemain.DataSource = dtDGV;
        }

        private void cBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPemain = new DataTable();
            sqlQuery = $"SELECT player_name, player_id FROM player WHERE team_id = '{cBox_Team.SelectedValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPemain);
            cBox_Pemain.DataSource = dtPemain;
            cBox_Pemain.ValueMember = "player_id";
            cBox_Pemain.DisplayMember = "player_name";
        }

        private void cBox_Pemain_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtdmatch = new DataTable();
            sqlQuery = $"SELECT * FROM dmatch WHERE player_id = '{cBox_Pemain.SelectedValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtdmatch);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtDGV.Rows.Add(tB_Minute.Text, cBox_Team.SelectedValue, cBox_Pemain.SelectedValue, cBox_Type.SelectedValue);
        }
    }
}
