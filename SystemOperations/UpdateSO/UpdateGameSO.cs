using Domain;

namespace SystemOperations.UpdateSO
{
    public class UpdateGameSO : SystemOperationBase
    {
        private Game updatedGame;

        public UpdateGameSO(Game updatedGame)
        {
            this.updatedGame = updatedGame;
        }

        protected override void Execute()
        {
            foreach (Stats st in updatedGame.Stats)
            {
                repository.Add(st);

                Player p = repository.GetObject(st.Player) as Player;
                p.Goals += st.Goals;
                repository.Update(p);
            }

            Team host = repository.GetObject(updatedGame.Host) as Team;
            host.GoalsScored += updatedGame.GoalsHost;
            host.GoalsConceded += updatedGame.GoalsGuest;

            Team guest = repository.GetObject(updatedGame.Guest) as Team;
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

            repository.Update(host);
            repository.Update(guest);
            repository.Update(updatedGame);
        }
    }
}
