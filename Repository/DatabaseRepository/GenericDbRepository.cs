using DatabaseBroker;
using Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository.DatabaseRepository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {
        private readonly Broker broker = new Broker();

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
            var command = broker.CreateCommand();

            command.CommandText = $"delete from {obj.TableName} where {obj.Condition}";

            command.ExecuteNonQuery();
        }

        public void Add(IDomainObject obj)
        {
            var command = broker.CreateCommand();

            command.CommandText = $"insert into {obj.TableName} values ({obj.InsertValues})";

            command.ExecuteNonQuery();
        }

        public List<IDomainObject> GetList(IDomainObject obj)
        {
            var result = new List<IDomainObject>();
            var command = broker.CreateCommand();

            command.CommandText = $"select * from {obj.TableName} {obj.Join} {obj.OrderBy}";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var rowObject = obj.ReadObjectRow(reader);

                    result.Add(rowObject);
                }
            }
            return result;
        }
        
        public List<IDomainObject> Search(IDomainObject obj)
        {
            var result = new List<IDomainObject>();
            var command = broker.CreateCommand();

            command.CommandText = $"SELECT * from {obj.TableName} {obj.Join} {obj.ConditionGetList} {obj.OrderBy}";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var rowObject = obj.ReadObjectRow(reader);

                    result.Add(rowObject);
                }
            }
            return result;
        }

        public void Update(IDomainObject obj)
        {
            var command = broker.CreateCommand();

            command.CommandText = $"UPDATE {obj.TableName} SET {obj.UpdateValues} WHERE {obj.Condition}";

            command.ExecuteNonQuery();            
        }

        public IDomainObject GetObject(IDomainObject obj)
        {
            IDomainObject result = null;

            var command = broker.CreateCommand();

            command.CommandText = $"SELECT * from {obj.TableName} {obj.Join} {obj.ConditionGetObject}";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var rowObject = obj.ReadObjectRow(reader);

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
