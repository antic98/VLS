using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
