using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.GetSO
{
    public class GetAllStatsSO : SystemOperationBase
    {
        public List<Stats> Result { get; private set; }
        protected override void Execute()
        {
            Result = repository.GetAll(new Stats()).OfType<Stats>().ToList();
        }
    }
}
