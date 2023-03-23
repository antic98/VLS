using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DatabaseRepository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();

        public void OpenConnection()
        {
            broker.OpenConnection();
        }
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }
        public void Commit()
        {
            broker.Commit();
        }
        public void Rollback()
        {
            broker.Rollback();
        }
        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Delete(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();

            command.CommandText = $"delete from {obj.TableName} where {obj.Condition}";

            command.ExecuteNonQuery();
        }

        public void Add(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();

            command.CommandText = $"insert into {obj.TableName} values ({obj.InsertValues})";

            command.ExecuteNonQuery();
        }

        public List<IDomainObject> GetAll(IDomainObject obj)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();

            command.CommandText = $"select * from {obj.TableName} {obj.Join} {obj.OrderBy}";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);

                    result.Add(rowObject);
                }
            }
            return result;
        }
        
        public List<IDomainObject> Search(IDomainObject obj)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();

            command.CommandText = $"SELECT * from {obj.TableName} {obj.Join} {obj.ConditionGetList} {obj.OrderBy}";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);

                    result.Add(rowObject);
                }
            }
            return result;
        }

        public void Update(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();

            command.CommandText = $"UPDATE {obj.TableName} SET {obj.UpdateValues} WHERE {obj.Condition}";

            command.ExecuteNonQuery();            
        }

        public IDomainObject GetObject(IDomainObject obj)
        {
            IDomainObject result = null;

            SqlCommand command = broker.CreateCommand();

            command.CommandText = $"SELECT * from {obj.TableName} {obj.Join} {obj.ConditionGetObject}";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);

                    if(rowObject.IDValue == obj.IDValue)
                    {
                        result = rowObject;
                    }
                }
            }

            return result;
        }

    }
}
