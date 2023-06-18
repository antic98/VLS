using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetAllSO
{
    public class GetAllStatsSO : SystemOperationBase
    {
        public List<Stats> Result { get; private set; }
        protected override void Execute()
        {
            Result = Repository.GetList(new Stats()).OfType<Stats>().ToList();
        }
    }
}
