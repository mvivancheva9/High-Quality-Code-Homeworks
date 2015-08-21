namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Points
    {
        private string playerName;
        private int pointsWon;

        public Points()
        { 
        }

        public Points(string playerName, int pointsWon)
        {
            this.playerName = playerName;
            this.pointsWon = pointsWon;
        }

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        public int PointsWon
        {
            get { return this.pointsWon; }
            set { this.pointsWon = value; }
        }
    }
}
