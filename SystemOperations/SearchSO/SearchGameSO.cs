using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SearchSO
{
    public class SearchGameSO : SystemOperationBase
    {
        private Game game;
        public List<Game> Result { get; private set; }

        public SearchGameSO(Game game)
        {
            this.game = game;
        }

        protected override void Execute()
        {
            Result = repository.Search(game).OfType<Game>().ToList();
        }
    }
}
