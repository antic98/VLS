using Domain;

namespace SystemOperations.UpdateSO
{
    public class UpdateGameSO : SystemOperationBase
    {
        private readonly Game updatedGame;

        public UpdateGameSO(Game updatedGame)
        {
            this.updatedGame = updatedGame;
        }

        protected override void Execute()
        {
            if (updatedGame?.Host == null || updatedGame.Guest == null) return;

            foreach (var st in updatedGame.Stats)
            {
                Repository.Add(st);

                if (!(Repository.GetObject(st.Player) is Player p)) continue;
                p.Goals += st.Goals;
                Repository.Update(p);
            }

            var host = Repository.GetObject(updatedGame.Host) as Team;
            host.GoalsScored += updatedGame.GoalsHost;
            host.GoalsConceded += updatedGame.GoalsGuest;

            var guest = Repository.GetObject(updatedGame.Guest) as Team;
            guest.GoalsScored += updatedGame.GoalsGuest;
            guest.GoalsConceded += updatedGame.GoalsHost;

            if (updatedGame.GoalsHost > updatedGame.GoalsGuest)
            {
                host.Points += 3;
                host.Wins += 1;
                guest.Loses += 1;             
            }
            if (updatedGame.GoalsHost < updatedGame.GoalsGuest)
            {
                guest.Points += 3;
                guest.Wins += 1;
                host.Loses += 1;
            }
            if (updatedGame.GoalsHost == updatedGame.GoalsGuest)
            {
                host.Points += 1;
                guest.Points += 1;
                host.Draws += 1;
                guest.Draws += 1;
            }

            Repository.Update(host);
            Repository.Update(guest);
            Repository.Update(updatedGame);
        }
    }
}
