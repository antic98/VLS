using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
