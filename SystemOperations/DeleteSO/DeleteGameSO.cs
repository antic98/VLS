using Domain;

namespace SystemOperations.DeleteSO
{
    public class DeleteGameSO : SystemOperationBase
    {
        private Game deleteGame;

        public DeleteGameSO(Game deleteGame)
        {
            this.deleteGame = deleteGame;
        }

        protected override void Execute()
        {
            if(deleteGame.GoalsHost == -1 && deleteGame.GoalsGuest == -1)
            {
                repository.Delete(deleteGame);
                return;
            }

            foreach (Stats st in deleteGame.Stats)
            {
                if(st.Game.ID == deleteGame.ID)
                {
                    Player p = repository.GetObject(st.Player) as Player;
                    p.Goals -= st.Goals;
                    repository.Update(p);
                    repository.Delete(st);
                }
            }

            Team host = repository.GetObject(deleteGame.Host) as Team;
            host.GoalsScored -= deleteGame.GoalsHost;
            host.GoalsConceded -= deleteGame.GoalsGuest;

            Team guest = repository.GetObject(deleteGame.Guest) as Team;
            guest.GoalsScored -= deleteGame.GoalsGuest;
            guest.GoalsConceded -= deleteGame.GoalsHost;

            if (deleteGame.GoalsHost > deleteGame.GoalsGuest)
            {
                host.Points -= 3;
                host.Wins -= 1;
                guest.Loses -= 1;
            }
            if (deleteGame.GoalsHost < deleteGame.GoalsGuest)
            {
                guest.Points -= 3;
                guest.Wins -= 1;
                host.Loses -= 1;
            }
            if (deleteGame.GoalsHost == deleteGame.GoalsGuest)
            {
                host.Points -= 1;
                guest.Points -= 1;
                host.Draws -= 1;
                guest.Draws -= 1;
            }

            repository.Update(host);
            repository.Update(guest);
            repository.Delete(deleteGame);
        }
    }
}
