using System;
using System.Collections.Generic;
using Domain;

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
            List<Tuple<string, string, DateTime>> fixtures = new List<Tuple<string, string, DateTime>>();

            int totalRounds = teams.Count - 1;
            int matchesPerRound = teams.Count / 2;

            List<Team> teamsCopy = new List<Team>(teams);
            teamsCopy.RemoveAt(0);

            for (int round = 0; round < totalRounds; round++)
            {
                int teamIdx = round % teamsCopy.Count;

                Team teamA = teams[0];
                Team teamB = teamsCopy[teamIdx];

                DateTime date = DateTime.Now.AddDays(round * 7);

                Game game = new Game();
                if(round % 2 == 0)
                {
                    game.Host = teamA;
                    game.Guest = teamB;
                }
                else
                {
                    game.Host = teamB;
                    game.Guest = teamA;
                }

                DateTime roundedDateTime = date.AddMinutes(30).AddMinutes(-date.Minute).AddSeconds(-date.Second);
                game.Date = roundedDateTime;

                game.DateString = game.Date.ToString("yyyy-MM-dd HH:mm");
                repository.Add(game);

                for (int i = 1; i < matchesPerRound; i++)
                {
                    int firstTeam = (round + i) % teamsCopy.Count;
                    int secondTeam = (round + teamsCopy.Count - i) % teamsCopy.Count;

                    teamA = teamsCopy[firstTeam];
                    teamB = teamsCopy[secondTeam];

                    date = DateTime.Now.AddDays(round * 7);

                    Game game1 = new Game();
                    if( i % 2 == 0)
                    {
                        game1.Host = teamA;
                        game1.Guest = teamB;
                    }
                    else
                    {
                        game1.Host = teamB;
                        game1.Guest = teamA;
                    }

                    DateTime roundedDateTime1 = date.AddMinutes(30).AddMinutes(-date.Minute).AddSeconds(-date.Second);
                    game1.Date = roundedDateTime;
                    game1.DateString = game1.Date.ToString("yyyy-MM-dd HH:mm");
                    repository.Add(game1);
                }
            }
        }
    }
}
