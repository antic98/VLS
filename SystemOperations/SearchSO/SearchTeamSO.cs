﻿using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.SearchSO
{
    public class SearchTeamSO : SystemOperationBase
    {
        private readonly Team team;
        public List<Team> Result { get; private set; }

        public SearchTeamSO(Team team)
        {
            this.team = team;
        }

        protected override void Execute()
        {
            if (team?.Search == null)
            {
                Result = null;
                return;
            }
            
            Result = Repository.Search(team).OfType<Team>().ToList();
        }
    }
}
