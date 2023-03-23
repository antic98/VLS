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
    public class Team : IDomainObject
    {
        int brojac;
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
        public string Group { get; set; }
        public override string ToString()
        {
            return Name;
        }
        [Browsable(false)]
        public List<Stats> Stats { get; set; }
        [Browsable(false)]
        public List<Game> Games { get; set; }
        [Browsable(false)]
        public List<Player> Players { get; set; }
        [Browsable(false)]
        public Team Self { get { return this; } }
        [Browsable(false)]
        public string TableName => "Team";
        [Browsable(false)]
        public string InsertValues => $"'{Name}','{City}','{Color}',0,0,0,0,0,0";
        [Browsable(false)]
        public string TableID => "ID";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string UpdateValues => $"Name = '{Name}', City = '{City}', Color = '{Color}', Wins = {Wins}, Draws = {Draws}, Loses = {Loses}, GoalsScored = {GoalsScored}, GoalsConceded = {GoalsConceded}, Points = {Points}";
        [Browsable(false)]
        public string Condition => $"ID = {ID}";
        [Browsable(false)]
        public string OrderBy => "ORDER BY Points DESC, (GoalsScored-GoalsConceded) DESC";
        [Browsable(false)]
        public string ConditionGetList => $"where lower(concat(name,city,color)) like '%{Name}%'";
        [Browsable(false)]
        public int IDValue => ID;
        [Browsable(false)]
        public string ConditionGetObject => $"WHERE ID = {ID}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Team t = new Team();

            t.Rank = ++brojac;
            t.ID = (int)reader["ID"];
            t.Name = (string)reader["Name"];
            t.City = (string)reader["City"];
            t.Color = (string)reader["Color"];
            t.Wins = (int)reader["Wins"];            
            t.Draws = (int)reader["Draws"];
            t.Loses = (int)reader["Loses"];
            t.MP = t.Wins + t.Draws + t.Loses;
            t.GoalsScored = (int)reader["GoalsScored"];
            t.GoalsConceded = (int)reader["GoalsConceded"];
            t.GD = t.GoalsScored - t.GoalsConceded;
            t.Points = (int)reader["Points"];

            return t;
        }
    }
}
