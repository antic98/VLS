using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetAllSO
{
    public class GetAllGamesSO : SystemOperationBase
    {
        public List<Game> Result { get; private set; }
        protected override void Execute()
        {
            Result = Repository.GetList(new Game()).OfType<Game>().ToList();
        }
    }
}
