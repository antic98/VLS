using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Game : IDomainObject
    {
        public Game()
        {
        }
        
        public Game(Team host, Team guest, DateTime date)
        {
            Host = host;
            Guest = guest;
            Date = date;
        }
        
        public Game(Team host, Team guest, string date)
        {
            Host = host;
            Guest = guest;
            DateString = date;
        }
        
        public Game(int id, Team host, Team guest, DateTime date)
        {
            ID = id;
            Host = host;
            Guest = guest;
            Date = date;
        }
        
        private string dateString;
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Team Host { get; set; }
        public int GoalsHost { get; set; }
        public int GoalsGuest { get; set; }
        public Team Guest { get; set; }
        public int Round { get; set; }

        [Browsable(false)]
        public List<Stats> Stats { get; set; }

        [Browsable(false)]
        public string DateString{ get; set; }

        [Browsable(false)]
        public string Search { get; set; }

        [Browsable(false)]
        public string TableName => "Game";
        [Browsable(false)] 
        public string InsertValues => $"'{DateString}',-1,-1,{Host.ID},{Guest.ID},{Round}";
        [Browsable(false)]
        public string Join => " g join team t1 on (g.HostID = t1.ID) join team t2 on (g.GuestID = t2.ID)";
        [Browsable(false)]
        public string UpdateValues => $"GoalsHost = {GoalsHost}, GoalsGuest = {GoalsGuest}";
        [Browsable(false)]
        public string Condition => $"ID = {ID}";
        [Browsable(false)]
        public string OrderBy => "order by Date ASC";
        [Browsable(false)]
        public string ConditionGetList => $"where lower(t1.Name) like '%{Search}%' or lower(t2.Name) like '%{Search}%'";
        [Browsable(false)]
        public int IDValue => ID;
        [Browsable(false)]
        public string ConditionGetObject => $"WHERE g.ID = {ID}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            var g = new Game
            {
                ID = reader.GetInt32(0),
                Date = reader.GetDateTime(1),
                GoalsHost = reader.GetInt32(2),
                GoalsGuest = reader.GetInt32(3),
                Round = reader.GetInt32(6),
                Host = new Team {
                    ID = reader.GetInt32(7),
                    Name = reader.GetString(8),
                    City = reader.GetString(9),
                    Color = reader.GetString(10),
                    Wins = reader.GetInt32(11),
                    Draws = reader.GetInt32(12),
                    Loses = reader.GetInt32(13),
                    GoalsScored = reader.GetInt32(14),
                    GoalsConceded = reader.GetInt32(15),
                    Points = reader.GetInt32(16)
                },
                Guest = new Team {
                    ID = reader.GetInt32(17),
                    Name = reader.GetString(18),
                    City = reader.GetString(19),
                    Color = reader.GetString(20),
                    Wins = reader.GetInt32(21),
                    Draws = reader.GetInt32(22),
                    Loses = reader.GetInt32(23),
                    GoalsScored = reader.GetInt32(24),
                    GoalsConceded = reader.GetInt32(25),
                    Points = reader.GetInt32(26)
                }
            };

            return g;
        }
    }
}
