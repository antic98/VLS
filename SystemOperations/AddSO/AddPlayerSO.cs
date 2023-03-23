using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddPlayerSO : SystemOperationBase
    {
        private readonly Player player;

        public AddPlayerSO(Player p)
        {
            this.player = p;
        }

        protected override void Execute()
        {
            repository.Add(player);
        }
    }
}
