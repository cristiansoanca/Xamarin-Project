using System;
using System.Collections.Generic;
using System.Text;
using XamarinProject.ViewModels;

namespace XamarinProject.Utils
{
    public class Player
    {
        public string Name { get; set; }
        private int _score = 0;
        public int Score { get { return _score; } set { _score += value; } }
        public bool DoubleScore { get; set; }
        public bool Turn { get; set; }
        public List<string> AvailableGames = new List<string>()
        {
            "Totale", "King", "Rentz", "Queens", "Ten", "Whist", "Diamonds", "Levate"
        };
        public bool TotaleView { get; set; } = true;
        public bool KingView { get; set; } = true;
        public bool RentzView { get; set; } = true;
        public bool QueensView { get; set; } = true;
        public bool TenView { get; set; } = true;
        public bool WhistView { get; set; } = true;
        public bool DiamondsView { get; set; } = true;
        public bool LevateView { get; set; } = true;

        public string CurrentGame { get; set; }

        public Player(string name)
        {
            Name = name;
        }        
    }
}
