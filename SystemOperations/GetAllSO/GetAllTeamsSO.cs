using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetAllSO
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
