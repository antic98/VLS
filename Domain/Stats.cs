using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Stats : IDomainObject
    {
        public Stats()
        {
        }
        
        public Stats(Game game, Player player, int goals)
        {
            Game = game;
            Player = player;
            Goals = goals;
        }
        
        public Game Game { get; set; }
        public Player Player { get; set; }
        public int Goals { get; set; }
        public override string ToString()
        {
            return Player.Name + " " + Player.Surname + " x " + Goals;
        }

        public string TableName => "Stats";

        public string InsertValues => $"{Player.ID}, {Game.ID}, {Goals}";
        
        public string Join => " s join Game g on (s.GameID = g.ID) join Player p on (s.PlayerID = p.ID)";

        public string UpdateValues => $"Goals = {Goals}";

        public string Condition => $"PlayerID={Player.ID} and GameID={Game.ID}";

        public string OrderBy => "";

        public string ConditionGetList => "";

        public int IDValue => 0;

        public string ConditionGetObject => "";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            var stats = new Stats
            {
                Goals = reader.GetInt32(2),
                Game = new Game
                {
                    ID = reader.GetInt32(3),
                    Date = reader.GetDateTime(4),
                    Host = new Team
                    {
                        ID = reader.GetInt32(7)
                    },                
                    Guest = new Team
                    {
                        ID = reader.GetInt32(8)
                    },
                    GoalsHost = reader.GetInt32(5),
                    GoalsGuest = reader.GetInt32(6),
                    Round = reader.GetInt32(9)
                },
                Player = new Player
                {
                    ID = reader.GetInt32(10),
                    Name = reader.GetString(11),
                    Surname = reader.GetString(12),

                    Position = new Position
                    {
                        ID = reader.GetInt32(13),
                    },

                    Team = new Team
                    {
                        ID = reader.GetInt32(14)
                    },
                    Country = new Country
                    {
                        ID = reader.GetInt32(15)
                    },
                    Goals = reader.GetInt32(16)
                }
            };

            return stats;
        }

    }
}
