using Domain;

namespace SystemOperations.DeleteSO
{
    public class DeleteGameSO : SystemOperationBase
    {
        private readonly Game game;

        public DeleteGameSO(Game game)
        {
            this.game = game;
        }

        protected override void Execute()
        {
            if (game == null)
            {
                return;
            }
            
            if(game.GoalsHost == -1 && game.GoalsGuest == -1)
            {
                repository.Delete(game);
                return;
            }

            foreach (Stats st in repository.GetAll(new Stats()))
            {
                if(st.Game.ID == game.ID)
                {
                    Player p = repository.GetObject(st.Player) as Player;
                    p.Goals -= st.Goals;
                    repository.Update(p);
                    repository.Delete(st);
                }
            }

            Team host = repository.GetObject(game.Host) as Team;
            host.GoalsScored -= game.GoalsHost;
            host.GoalsConceded -= game.GoalsGuest;

            Team guest = repository.GetObject(game.Guest) as Team;
            guest.GoalsScored -= game.GoalsGuest;
            guest.GoalsConceded -= game.GoalsHost;

            if (game.GoalsHost > game.GoalsGuest)
            {
                host.Points -= 3;
                host.Wins -= 1;
                guest.Loses -= 1;
            }
            if (game.GoalsHost < game.GoalsGuest)
            {
                guest.Points -= 3;
                guest.Wins -= 1;
                host.Loses -= 1;
            }
            if (game.GoalsHost == game.GoalsGuest)
            {
                host.Points -= 1;
                guest.Points -= 1;
                host.Draws -= 1;
                guest.Draws -= 1;
            }

            repository.Update(host);
            repository.Update(guest);
            repository.Delete(game);
        }
    }
}
