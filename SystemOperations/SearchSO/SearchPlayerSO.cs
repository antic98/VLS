using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Result = repository.Search(player).OfType<Player>().ToList();
        }
    }
}
