using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetAllSO
{
    public class GetAllUsersSO : SystemOperationBase
    {
        public List<User> Result { get; private set; }

        protected override void Execute()
        {
            Result = Repository.GetList(new User()).OfType<User>().ToList();
        }
    }
}
