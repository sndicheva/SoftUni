using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            players = new List<Player>();
        }

        public IReadOnlyCollection<Player> Players => players;
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public int Count => Players.Count;
        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if (OpenPositions == 0)
            {
                return "There are no more open positions.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }
        public bool RemovePlayer(string name)
        {
            var targetPlayer = Players.FirstOrDefault(p => p.Name == name);
            if (targetPlayer == null)
            {
                return false;
            }
            players.Remove(targetPlayer);
            OpenPositions++;
            return true;
        }
        public int RemovePlayerByPosition(string position)
        {
            int countOfRemovedPlayers = 0;
            while (Players.FirstOrDefault(p => p.Position == position) != null)
            {
                var targetPlayer = Players.FirstOrDefault(p => p.Position == position);
                players.Remove(targetPlayer);
                OpenPositions++;
                countOfRemovedPlayers++;
            }

            return countOfRemovedPlayers;
        }
        public Player RetirePlayer(string name)
        {
            var targetPlayer = Players.FirstOrDefault(p => p.Name == name);
            if (targetPlayer == null)
            {
                return null;
            }
            targetPlayer.Retired = true;
            return targetPlayer;
        }

        public List<Player> AwardPlayers(int games)
        {
            return Players.Where(p => p.Games >= games).ToList();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (var player in Players.Where(p => p.Retired == false))
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
