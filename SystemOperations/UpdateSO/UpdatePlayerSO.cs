using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UpdateSO
{
    public class UpdatePlayerSO : SystemOperationBase
    {
        private Player updatedPlayer;

        public UpdatePlayerSO(Player updatedPlayer)
        {
            this.updatedPlayer = updatedPlayer;
        }

        protected override void Execute()
        {
            Player upd = repository.GetObject(updatedPlayer) as Player;

            updatedPlayer.Goals = upd.Goals;
            
            if(updatedPlayer.Team.ID != upd.Team.ID)
            {
                foreach(Stats st in updatedPlayer.Stats)
                {
                    if(st.Player.ID == updatedPlayer.ID)
                    {
                        repository.Delete(st);
                    }
                }
            }

            repository.Update(updatedPlayer);
        }
    }
}
