using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AddSO
{
    public class AddGamesSO : SystemOperationBase
    {
        private List<Team> teams = new List<Team>();

        public AddGamesSO(List<Team> teams)
        {
            this.teams = teams;
        }

        protected override void Execute()
        {
            var result = new List<List<Tuple<Team, Team>>>();

            int teamsSize = teams.Count;
            int numDays = (teamsSize - 1) * 2;
            int halfSize = teamsSize / 2;
            DateTime date = DateTime.Now;
            var teams1 = new List<Team>();

            teams1.AddRange(teams.Skip(halfSize).Take(halfSize));
            teams1.AddRange(teams.Skip(1).Take(halfSize - 1).ToArray().Reverse());

            for (int day = 0; day < numDays; day++)
            {
                var round = new List<Tuple<Team, Team>>();
                int teamIdx = day % teamsSize;
                round.Add(new Tuple<Team, Team>(teams1[teamIdx], teams[0]));

                for (int idx = 1; idx < halfSize; idx++)
                {
                    int firstTeam = (day + idx) % teamsSize;
                    int secondTeam = (day + teamsSize - idx) % teamsSize;

                    round.Add(new Tuple<Team, Team>(teams1[firstTeam], teams1[secondTeam]));
                }
                result.Add(round);
            }


        }
    }
}
