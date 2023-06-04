using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class User : IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [Browsable(false)]
        public string TableName => "[User]";
        [Browsable(false)]
        public string InsertValues => $"{ID},'{Name}','{Surname}','{Username}','{Password}'";

        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string Condition => "";
        [Browsable(false)]
        public string OrderBy => "";
        [Browsable(false)]
        public string ConditionGetList => "";
        [Browsable(false)]
        public int IDValue => ID;
        [Browsable(false)]
        public string ConditionGetObject => "";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            var u = new User
            {
                ID = (int)reader["ID"],
                Name = (string)reader["Name"],
                Surname = (string)reader["Surname"],
                Username = (string)reader["Username"],
                Password = (string)reader["Password"]
            };

            return u;
        }
    }
}
