using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddTeamSO : SystemOperationBase
    {
        private readonly Team team;
        public AddTeamSO(Team t)
        {
            this.team = t;
        }
        protected override void Execute()
        {
            repository.Add(team);
        }
    }
}
