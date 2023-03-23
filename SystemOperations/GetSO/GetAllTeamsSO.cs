using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetAllTeamsSO : SystemOperationBase
    {
        public List<Team> Result { get; private set; }
        protected override void Execute()
        {
            Result = repository.GetAll(new Team()).OfType<Team>().ToList();
        }
    }
}
