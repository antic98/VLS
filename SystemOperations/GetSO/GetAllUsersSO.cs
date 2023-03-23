using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
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
