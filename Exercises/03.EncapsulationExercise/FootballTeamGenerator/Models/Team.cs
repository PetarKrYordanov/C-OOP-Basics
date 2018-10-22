using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
   public class Team
    {
        private string name;
        private int rating;
        private List<Player> players;

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.ValidateName(value);
                this.name = value;
            }
        }

        public int Rating
        {
            get { return this.rating; }
           
        }
        public Team(string name)
        {
            this.Name = name;
            players = new List<Player>();
        }

        public void RemovePlayer(string playerName)
        {
            var player = this.players.FirstOrDefault(e => e.Name == playerName);
            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            this.players.Remove(player);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public int GetTeamRating()
        {
            if (players.Count == 0)
            {
                this.rating = 0;
                return 0;
            }
            var rating =(int)Math.Round( players.Average(e => (e.Skills).Sum() / 5.0),0); 
            this.rating = rating;
            return rating;
        }
    }
}
