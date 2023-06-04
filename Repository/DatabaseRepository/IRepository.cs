using System.Collections.Generic;
using Domain;

namespace Repository.DatabaseRepository
{
    public interface IRepository <T> where T : class
    {
        List<T> GetAll(T obj);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(T obj);
        T GetObject(T obj);

        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
