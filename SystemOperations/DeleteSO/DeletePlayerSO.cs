using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.DeleteSO
{
    public class DeletePlayerSO : SystemOperationBase
    {
        private Player deletePlayer;

        public DeletePlayerSO(Player deletePlayer)
        {
            this.deletePlayer = deletePlayer;
        }

        protected override void Execute()
        {
            foreach(Stats st in deletePlayer.Stats)
            {
                if(st.Player.ID == deletePlayer.ID)
                {
                    repository.Delete(st);
                }
            }

            repository.Delete(deletePlayer);
        }
    }
}
