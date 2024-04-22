using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace W05___Practice___Take_Home_W04_Solution
{
    internal class Player
    {
        private string playerName;
        private string playerNum;
        private string playerPos;

        //Constructor -- dipanggil setiap classnya dibuat
        public Player(string _playerName, string _playerNum, string _playerPos)
        {
            playerName = _playerName;
            playerPos = _playerPos;
            playerNum = _playerNum;
        }

        //Getter -- return value daru sebuah attribute
        public string getPlayerName() { return playerName; }
        public string getPlayerNum() {  return playerNum; }
        public string getPlayerPos() {  return playerPos; }

        //Setter - set value dari sebuah attribute
        public void setPlayerName(string _playerName) {  this.playerName = _playerName; }
        public void setPlayerNum(string _playerNum) {  this.playerNum = _playerNum; }
        public void setPlayerPos(string _playerPos) {  this.playerPos = _playerPos; }

    }
}
