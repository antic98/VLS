using Domain;

namespace SystemOperations.AddSO
{
    public class AddGameSO : SystemOperationBase
    {
        private readonly Game game;

        public AddGameSO(Game game)
        {
            this.game = game;
        }
        
        protected override void Execute()
        {
            if (game.Host != null && game.Guest != null)
            {
                game.GoalsHost = -1;
                game.GoalsGuest = -1;
                Repository.Add(game);
            }
        }
    }
}