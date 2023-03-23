using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Game : IDomainObject
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Team Host { get; set; }
        public int GoalsHost { get; set; }
        public int GoalsGuest { get; set; }
        public Team Guest { get; set; }
        //public int Round { get; set; }

        [Browsable(false)]
        public List<Stats> Stats { get; set; }

        [Browsable(false)]
        public string DateString { get; set; }

        [Browsable(false)]
        public string Search { get; set; }

        [Browsable(false)]
        public string TableName => "Game";
        [Browsable(false)] 
        public string InsertValues => $"'{DateString}',-1,-1,{Host.ID},{Guest.ID}";
        [Browsable(false)]
        public string TableID => "ID";
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
            Game g = new Game();

            g.ID = reader.GetInt32(0);
            g.Date = reader.GetDateTime(1);
            g.GoalsHost = reader.GetInt32(2);
            g.GoalsGuest = reader.GetInt32(3);
            g.Host = new Team {
                ID = reader.GetInt32(6),
                Name = reader.GetString(7),
                City = reader.GetString(8),
                Color = reader.GetString(9),
                Wins = reader.GetInt32(10),
                Draws = reader.GetInt32(11),
                Loses = reader.GetInt32(12),
                GoalsScored = reader.GetInt32(13),
                GoalsConceded = reader.GetInt32(14),
                Points = reader.GetInt32(15)
            };
            g.Guest = new Team {
                ID = reader.GetInt32(16),
                Name = reader.GetString(17),
                City = reader.GetString(18),
                Color = reader.GetString(19),
                Wins = reader.GetInt32(20),
                Draws = reader.GetInt32(21),
                Loses = reader.GetInt32(22),
                GoalsScored = reader.GetInt32(23),
                GoalsConceded = reader.GetInt32(24),
                Points = reader.GetInt32(25)
            };

            return g;
        }
    }
}
