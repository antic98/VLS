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
    public class Player : IDomainObject
    {
        int brojac;

        public int Rank { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }
        public Country Country { get; set; }
        public Team Team { get; set; }
        public int Goals { get; set; }
        [Browsable(false)]
        public List<Stats> Stats { get; set; }
        [Browsable(false)]
        public string TableName => "Player";
        [Browsable(false)]
        public string InsertValues => $"'{Name}','{Surname}',{(int)Position},{Team.ID},{Country.ID},{Goals}";
        [Browsable(false)]
        public string TableID => "ID";
        [Browsable(false)]
        public string Join => " p join Country c on (p.Country = c.ID) join Team t on (p.Team = t.ID)";
        [Browsable(false)]
        public string UpdateValues => $"Name = '{Name}', Surname = '{Surname}', Position = {(int)Position}, Country = {Country.ID}, Team = {Team.ID}, Goals = {Goals}";
        [Browsable(false)]
        public string Condition => $"ID = {ID}";
        [Browsable(false)]
        public string OrderBy => "ORDER BY Goals DESC";
        [Browsable(false)]
        public string ConditionGetList => $"where lower(concat(p.name,p.surname,t.Name,c.Name)) like '%{Name}%' or lower(concat(p.surname,p.name,t.Name,c.Name)) like '%{Name}%'";
        [Browsable(false)]
        public int IDValue => ID;
        [Browsable(false)]
        public string ConditionGetObject => $"WHERE p.ID = {ID}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Player p = new Player();

            p.Rank = ++brojac;
            p.ID = reader.GetInt32(0);
            p.Name = reader.GetString(1);
            p.Surname = reader.GetString(2);
            p.Position = (Position)reader.GetInt32(3);
            p.Goals = reader.GetInt32(6);

            p.Country = new Country
            {
                ID = reader.GetInt32(7),
                Name = reader.GetString(8)
            };

            p.Team = new Team
            {
                ID = reader.GetInt32(9),
                Name = reader.GetString(10),
                City = reader.GetString(11),
                Color = reader.GetString(12),                
            };
            
            return p;
        }
    }
}
