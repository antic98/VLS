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
                Repository.Delete(game);
                return;
            }

            foreach (var o in Repository.GetAll(new Stats()))
            {
                var st = (Stats)o;
                if (st.Game.ID != game.ID) continue;
                if (Repository.GetObject(st.Player) is Player p)
                {
                    p.Goals -= st.Goals;
                    Repository.Update(p);
                }

                Repository.Delete(st);
            }

            var host = Repository.GetObject(game.Host) as Team;
            host.GoalsScored -= game.GoalsHost;
            host.GoalsConceded -= game.GoalsGuest;

            var guest = Repository.GetObject(game.Guest) as Team;
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

            Repository.Update(host);
            Repository.Update(guest);
            Repository.Delete(game);
        }
    }
}
