using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations
{
    public class GetAllPlayersSO : SystemOperationBase
    {
        public List<Player> Result { get; private set; }
        protected override void Execute()
        {
            Result = repository.GetAll(new Player()).OfType<Player>().ToList();
        }
    }
}
