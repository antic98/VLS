using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Country : IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public Country()
        {
        }

        public Country(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        [Browsable(false)]
        public Country Self { get { return this; } }
        [Browsable(false)]
        public string TableName => "Country";
        [Browsable(false)]
        public string InsertValues => $"'{Name}'";
        [Browsable(false)]
        public string TableID => "ID";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string UpdateValues => $"Name = '{Name}'";
        [Browsable(false)]
        public string Condition => "";
        [Browsable(false)]
        public string OrderBy => "order by name";
        [Browsable(false)]
        public string ConditionGetList => "";
        [Browsable(false)]
        public int IDValue => ID;

        public string ConditionGetObject => "";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Country c = new Country();

            c.ID = (int)reader["ID"];
            c.Name = (string)reader["Name"];
           
            return c;
        }        
    }
}
