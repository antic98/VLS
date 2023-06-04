using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Team : IDomainObject
    {
        public Team()
        {
        }
        
        public Team(string name, string city, string color)
        {
            Name = name;
            City = city;
            Color = color;
        }

        public Team(int id, string name, string city, string color)
        {
            ID = id;
            Name = name;
            City = city;
            Color = color;
        }

        private int brojac;
        public int Rank { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Color { get; set; }
        public int MP { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int GD { get; set; }
        public int Points { get; set; }
        
        [Browsable(false)]
        public string Search { get; set; }
        public override string ToString()
        {
            return Name;
        }
        [Browsable(false)]
        public List<Player> Players { get; set; }

        [Browsable(false)]
        public string TableName => "Team";
        [Browsable(false)]
        public string InsertValues => $"'{Name}','{City}','{Color}',0,0,0,0,0,0";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string UpdateValues => $"Name = '{Name}', City = '{City}', Color = '{Color}', Wins = {Wins}, Draws = {Draws}, Loses = {Loses}, GoalsScored = {GoalsScored}, GoalsConceded = {GoalsConceded}, Points = {Points}";
        [Browsable(false)]
        public string Condition => $"ID = {ID}";
        [Browsable(false)]
        public string OrderBy => "ORDER BY Points DESC, (GoalsScored-GoalsConceded) DESC";
        [Browsable(false)]
        public string ConditionGetList => $"where lower(concat(name,city,color)) like '%{Search}%'";
        [Browsable(false)]
        public int IDValue => ID;
        [Browsable(false)]
        public string ConditionGetObject => $"WHERE ID = {ID}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            var t = new Team
            {
                Rank = ++brojac,
                ID = (int)reader["ID"],
                Name = (string)reader["Name"],
                City = (string)reader["City"],
                Color = (string)reader["Color"],
                Wins = (int)reader["Wins"],
                Draws = (int)reader["Draws"],
                Loses = (int)reader["Loses"],
                MP = Wins + Draws + Loses,
                GoalsScored = (int)reader["GoalsScored"],
                GoalsConceded = (int)reader["GoalsConceded"],
                GD = GoalsScored - GoalsConceded,
                Points = (int)reader["Points"]
            };

            return t;
        }
    }
}
