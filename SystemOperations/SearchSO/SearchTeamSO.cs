using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SearchSO
{
    public class SearchTeamSO : SystemOperationBase
    {
        private Team team;
        public List<Team> Result { get; private set; }

        public SearchTeamSO(Team team)
        {
            this.team = team;
        }

        protected override void Execute()
        {
            Result = repository.Search(team).OfType<Team>().ToList();
        }
    }
}
