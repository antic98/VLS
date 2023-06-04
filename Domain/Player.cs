using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Player : IDomainObject
    {
        int brojac;

        public Player()
        {
        }
        
        public Player(string name,
            string surname,
            Position position,
            Country country,
            Team team)
        {
            Name = name;
            Surname = surname;
            Position = position;
            Country = country;
            Team = team;
        }

        public Player(int id,
            string name,
            string surname,
            Position position,
            Country country,
            Team team)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Position = position;
            Country = country;
            Team = team;
        }
        
        public int Rank { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }
        public Country Country { get; set; }
        public Team Team { get; set; }
        public int Goals { get; set; }
        
        [Browsable(false)]
        public string Search { get; set; }
        [Browsable(false)]
        public string TableName => "Player";
        [Browsable(false)]
        public string InsertValues => $"'{Name}','{Surname}',{Position.ID},{Team.ID},{Country.ID},{Goals}";
        [Browsable(false)]
        public string Join => " p join Country c on (p.Country = c.ID) join Team t on (p.Team = t.ID) join Position pos on (p.Position = pos.ID)";
        [Browsable(false)]
        public string UpdateValues => $"Name = '{Name}', Surname = '{Surname}', Position = {Position.ID}, Country = {Country.ID}, Team = {Team.ID}, Goals = {Goals}";
        [Browsable(false)]
        public string Condition => $"ID = {ID}";
        [Browsable(false)]
        public string OrderBy => "ORDER BY Goals DESC";
        [Browsable(false)]
        public string ConditionGetList => $"where lower(concat(p.Name,p.Surname,t.Name,c.Name,pos.Name)) like '%{Search}%'";
        [Browsable(false)]
        public int IDValue => ID;
        [Browsable(false)]
        public string ConditionGetObject => $"WHERE p.ID = {ID}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            var p = new Player
            {
                Rank = ++brojac,
                ID = reader.GetInt32(0),
                Name = reader.GetString(1),
                Surname = reader.GetString(2),
                Goals = reader.GetInt32(6),
                Country = new Country
                {
                    ID = reader.GetInt32(7),
                    Name = reader.GetString(8)
                },
                Team = new Team
                {
                    ID = reader.GetInt32(9),
                    Name = reader.GetString(10),
                    City = reader.GetString(11),
                    Color = reader.GetString(12),                
                },
                Position = new Position
                {
                    ID = reader.GetInt32(19),
                    Name = reader.GetString(20)
                }
            };

            return p;
        }
    }
}
