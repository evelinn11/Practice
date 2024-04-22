using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05___Practice___Take_Home_W04_Solution
{
    public partial class Form1 : Form
    {
        List<Team> teams;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teams = new List<Team>();
            List<Player> players = new List<Player>()
            {
                new Player("Felicia", "02", "GK"),
                new Player("Amira", "33", "DF"),
                new Player("Celin", "19", "FW"),
                new Player("Angeline", "08", "FW")
            };
            teams.Add(new Team("Tim Evelyn", "Indonesia", "Surabaya", players));
            players = new List<Player>()
            {
                new Player("Felicia", "02", "GK"),
                new Player("Amira", "33", "DF"),
                new Player("Celin", "19", "FW"),
                new Player("Angeline", "08", "FW"),
                new Player("Evelyn", "01", "DF"),
                new Player("Evelin", "21", "FW"),
                new Player("Micheelle", "68", "FW")
            };
            teams.Add(new Team("ERP MonsoonSIM", "Indonesia", "Surbaya", players));
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            foreach(Team t in teams)
            {
                t.AddPlayer(new Player("Evelin", "21", "DK"));
                string output = t.getTeamName() + " is a " + t.getTeamCountry() + " team with " + t.getPlayerList().Count().ToString() + " players.";
                MessageBox.Show(output);
            }
        }
    }
}
