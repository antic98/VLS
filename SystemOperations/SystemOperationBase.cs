using Domain;
using Repository.DatabaseRepository;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> Repository;

        public void ExecuteTemplate(IRepository<IDomainObject> repository)
        {
            Repository = repository;

            try
            {
                Repository.OpenConnection();
                Repository.BeginTransaction();

                Execute();

                Repository.Commit();
            }
            catch
            {
                Repository.Rollback();
                throw;
            }
            finally
            {
                Repository.CloseConnection();
            }
        }

        public void ExecuteTemplate()
        {
            Repository = new GenericDbRepository();

            try
            {
                Repository.OpenConnection();
                Repository.BeginTransaction();

                Execute();

                Repository.Commit();
            }
            catch
            {
                Repository.Rollback();
                throw;
            }
            finally
            {
                Repository.CloseConnection();
            }
        }

        protected abstract void Execute();
    }
}
