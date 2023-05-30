using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.GetSO
{
    public class GetAllGamesSO : SystemOperationBase
    {
        public List<Game> Result { get; private set; }
        protected override void Execute()
        {
            Result = repository.GetAll(new Game()).OfType<Game>().ToList();
        }
    }
}
