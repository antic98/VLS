using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.SearchSO
{
    public class SearchPlayerSO : SystemOperationBase
    {
        private readonly Player player;
        public List<Player> Result { get; private set; }

        public SearchPlayerSO(Player player)
        {
            this.player = player;
        }

        protected override void Execute()
        {
            if (player?.Search == null)
            {
                Result = null;
                return;
            }
            
            Result = Repository.Search(player).OfType<Player>().ToList();
        }
    }
}
