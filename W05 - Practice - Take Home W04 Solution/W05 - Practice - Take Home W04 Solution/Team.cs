using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05___Practice___Take_Home_W04_Solution
{
    internal class Team
    {
        private string teamName;
        private string teamCountry;
        private string teamCity;
        private List<Player> playerList = new List<Player>();

        public Team(string teamName, string teamCountry, string teamCity, List<Player> playerList)
        {
            this.teamName = teamName;
            this.teamCountry = teamCountry;
            this.teamCity = teamCity;
            this.playerList = playerList;
        }
 

        //Getter
        public string getTeamName() { return teamName; }
        public string getTeamCountry() {  return teamCountry; }
        public string getTeamCity() {  return teamCity; }
        public List<Player> getPlayerList() {  return playerList; }

        //Setter
        public void setTeamName(string _teamName) {  this.teamName = _teamName; }
        public void setTeamCountry(string _teamCountry) {  this.teamCountry = _teamCountry; }
        public void setTeamCity(string _teamCity) {  this.teamCity = _teamCity; }
        public void setTeamPlayer(List<Player> players) { this.playerList = players;}

        public void AddPlayer(Player player)
        {
            bool kembar = false;
            foreach (Player p in playerList)
            {
                if (p.getPlayerNum() == player.getPlayerNum())
                {
                    kembar = true;
                    break;
                }
            }
            if (kembar)
            {
                MessageBox.Show("Ada player dengan nama yang sama");
            }
            else
            {
                playerList.Add(player);
            }
        }
    }
}
