using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.SearchSO
{
    public class SearchGameSO : SystemOperationBase
    {
        private readonly Game game;
        public List<Game> Result { get; private set; }

        public SearchGameSO(Game game)
        {
            this.game = game;
        }

        protected override void Execute()
        {
            if (game?.Search == null)
            {
                Result = null;
                return;
            }
            
            Result = Repository.Search(game).OfType<Game>().ToList();
        }
    }
}
