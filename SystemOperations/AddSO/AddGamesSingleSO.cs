using System;
using System.Collections.Generic;
using Domain;

namespace SystemOperations.AddSO
{
    public class AddGamesSingleSO : SystemOperationBase
    {
        private readonly List<Team> teams;

        public AddGamesSingleSO(List<Team> teams)
        {
            this.teams = teams;
        }

        protected override void Execute()
        {
            if (teams.Count % 2 == 0 && teams.Count >= 2)
                MakeFixtures();
        }

        private void MakeFixtures()
        {
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

                Game game;
                DateTime roundedDateTime = date.AddMinutes(30).AddMinutes(-date.Minute).AddSeconds(-date.Second);
                if(round % 2 == 0)
                {
                    game = new Game(teamA, teamB, roundedDateTime);
                }
                else
                {
                    game = new Game(teamB, teamA, roundedDateTime);
                }
                
                game.Round = round + 1;
                
                repository.Add(game);

                for (int i = 1; i < matchesPerRound; i++)
                {
                    int firstTeam = (round + i) % teamsCopy.Count;
                    int secondTeam = (round + teamsCopy.Count - i) % teamsCopy.Count;

                    teamA = teamsCopy[firstTeam];
                    teamB = teamsCopy[secondTeam];

                    date = DateTime.Now.AddDays(round * 7);

                    Game game1;
                    DateTime roundedDateTime1 = date.AddMinutes(30).AddMinutes(-date.Minute).AddSeconds(-date.Second);

                    if( i % 2 == 0)
                    {
                        game1 = new Game(teamA, teamB, roundedDateTime1);
                    }
                    else
                    {
                        game1 = new Game(teamB, teamA, roundedDateTime1);
                    }

                    game1.Round = round + 1;
                    
                    repository.Add(game1);
                }
            }
        }
    }
}
