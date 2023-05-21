using Domain;
using Repository.DatabaseRepository;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> repository;

        public void ExecuteTemplate(IRepository<IDomainObject> repository)
        {
            this.repository = repository;

            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();

                Execute();

                repository.Commit();
            }
            catch
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        public void ExecuteTemplate()
        {
            this.repository = new GenericDbRepository();

            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();

                Execute();

                repository.Commit();
            }
            catch
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void Execute();
    }
}
