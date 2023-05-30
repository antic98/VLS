using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.SearchSO
{
    public class SearchPlayerSO : SystemOperationBase
    {
        private Player player;
        public List<Player> Result { get; private set; }

        public SearchPlayerSO(Player player)
        {
            this.player = player;
        }

        protected override void Execute()
        {
            if (player?.Name == null)
            {
                Result = null;
                return;
            }
            
            Result = repository.Search(player).OfType<Player>().ToList();
        }
    }
}
