using System;
using System.Collections.Generic;
using Domain;

namespace SystemOperations.AddSO
{
    public class AddGamesDoubleSO : SystemOperationBase
    {
        private List<Team> teams = new List<Team>();

        public AddGamesDoubleSO(List<Team> teams)
        {
            this.teams = teams;
        }

        protected override void Execute()
        {
            if (teams?.Count % 2 == 1 || teams?.Count < 2) return;

            MakeFixtures();
        }

        private void MakeFixtures()
        {
            int totalRounds = teams.Count - 1;
            int matchesPerRound = teams.Count / 2;
            int dateCounter = 0;

            List<Team> teamsCopy = new List<Team>(teams);
            teamsCopy.RemoveAt(0);

            for (int round = 0; round < totalRounds; round++)
            {
                int teamIdx = round % teamsCopy.Count;

                Team teamA = teams[0];
                Team teamB = teamsCopy[teamIdx];

                DateTime date = DateTime.Now.AddDays((dateCounter++) * 7);

                Game game = new Game();
                game.Round = round + 1;

                if (round % 2 == 0)
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
                    game1.Round = round + 1;

                    if (i % 2 == 0)
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
                    game1.Date = roundedDateTime1;
                    game1.DateString = game1.Date.ToString("yyyy-MM-dd HH:mm");
                    repository.Add(game1);
                }
            }

            for (int round = 0; round < totalRounds; round++)
            {
                int teamIdx = round % teamsCopy.Count;

                Team teamA = teams[0];
                Team teamB = teamsCopy[teamIdx];

                DateTime date = DateTime.Now.AddDays((dateCounter++) * 7);

                Game game = new Game();
                game.Round = round + 1;

                if (round % 2 == 0)
                {
                    game.Host = teamB;
                    game.Guest = teamA;
                }
                else
                {
                    game.Host = teamA;
                    game.Guest = teamB;
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
                    game1.Round = round + 1;

                    if (i % 2 == 0)
                    {
                        game1.Host = teamB;
                        game1.Guest = teamA;
                    }
                    else
                    {
                        game1.Host = teamA;
                        game1.Guest = teamB;
                    }

                    DateTime roundedDateTime1 = date.AddMinutes(30).AddMinutes(-date.Minute).AddSeconds(-date.Second);
                    game1.Date = roundedDateTime1;
                    game1.DateString = game1.Date.ToString("yyyy-MM-dd HH:mm");
                    repository.Add(game1);
                }
            }
        }
    }
}
