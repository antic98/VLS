using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
