using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetSO
{
    public class GetAllUsersSO : SystemOperationBase
    {
        public List<User> Result { get; private set; }

        protected override void Execute()
        {
            Result = repository.GetAll(new User()).OfType<User>().ToList();
        }
    }
}
