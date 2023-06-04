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
            var totalRounds = teams.Count - 1;
            var matchesPerRound = teams.Count / 2;

            var teamsCopy = new List<Team>(teams);
            teamsCopy.RemoveAt(0);

            for (var round = 0; round < totalRounds; round++)
            {
                var teamIdx = round % teamsCopy.Count;

                var teamA = teams[0];
                var teamB = teamsCopy[teamIdx];

                var date = DateTime.Now.AddDays(round * 7);

                var roundedDateTime = date.AddMinutes(30).AddMinutes(-date.Minute).AddSeconds(-date.Second);
                var dateString = roundedDateTime.ToString("yyyy-MM-dd HH:mm");
                
                var game = round % 2 == 0 ? new Game(teamA, teamB, dateString) : new Game(teamB, teamA, dateString);
                
                game.Round = round + 1;
                
                Repository.Add(game);

                for (var i = 1; i < matchesPerRound; i++)
                {
                    var firstTeam = (round + i) % teamsCopy.Count;
                    var secondTeam = (round + teamsCopy.Count - i) % teamsCopy.Count;

                    teamA = teamsCopy[firstTeam];
                    teamB = teamsCopy[secondTeam];

                    date = DateTime.Now.AddDays(round * 7);

                    var roundedDateTime1 = date.AddMinutes(30).AddMinutes(-date.Minute).AddSeconds(-date.Second);
                    var dateString1 = roundedDateTime1.ToString("yyyy-MM-dd HH:mm");

                    var game1 = i % 2 == 0 ? new Game(teamA, teamB, dateString1) : new Game(teamB, teamA, dateString1);

                    game1.Round = round + 1;
                    
                    Repository.Add(game1);
                }
            }
        }
    }
}
