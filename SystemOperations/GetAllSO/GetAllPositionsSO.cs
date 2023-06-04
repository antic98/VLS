using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetAllSO
{
    public class GetAllPositionsSO : SystemOperationBase
    {
        public List<Position> Result { get; private set; }
        protected override void Execute()
        {
            Result = repository.GetAll(new Position()).OfType<Position>().ToList();
        }
    }
}
