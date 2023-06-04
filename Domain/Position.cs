﻿using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Position : IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        [Browsable(false)]
        public Position Self { get { return this; } }
        [Browsable(false)]
        public string TableName => "Position";
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
            Position p = new Position();

            p.ID = (int)reader["ID"];
            p.Name = (string)reader["Name"];

            return p;
        }
    }
}
