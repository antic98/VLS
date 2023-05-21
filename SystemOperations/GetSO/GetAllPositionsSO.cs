using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations
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
