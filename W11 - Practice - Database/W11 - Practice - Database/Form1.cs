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

namespace W11___Practice___Database
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtTeam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtTeam = new DataTable();
            sqlConnect = new MySqlConnection("server=localhost;uid=student;pwd=isbmantap;database=premier_league");
            sqlQuery = "SELECT t.team_id AS 'Team ID', t.team_name AS 'Team Name', t.home_stadium AS 'Home Stadium', t.capacity AS 'Capacity', t.city AS 'City', ma.manager_name AS 'Manager Name', ass.manager_name AS 'Assistant Manager Name', p.player_name AS 'Captain Name' FROM team t JOIN manager ma ON t.manager_id = ma.manager_id JOIN manager ass ON t.assmanager_id = ass.manager_id JOIN player p ON p.player_id = t.captain_id";
            //sqlQuery = "SELECT m.match_id, m.match_date, t.team_name as 'Team Home', t2.team_name as 'Team Away' FROM `match` m JOIN team t ON t.team_id = m.team_home JOIN team t2 ON t2.team_id = m.team_away";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);
            dGV_Team.DataSource = dtTeam;
        }
    }
}
