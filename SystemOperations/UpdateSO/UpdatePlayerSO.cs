using System.Linq;
using Domain;

namespace SystemOperations.UpdateSO
{
    public class UpdatePlayerSO : SystemOperationBase
    {
        private readonly Player updatedPlayer;

        public UpdatePlayerSO(Player updatedPlayer)
        {
            this.updatedPlayer = updatedPlayer;
        }

        protected override void Execute()
        {
            if (updatedPlayer == null || updatedPlayer.Name == null || updatedPlayer.Surname == null || updatedPlayer.Position == null
                || updatedPlayer.Country == null || updatedPlayer.Team == null) return;
            
            if (Repository.GetObject(updatedPlayer) is Player upd)
            {
                updatedPlayer.Goals = upd.Goals;
            
                if(updatedPlayer.Team.ID != upd.Team.ID)
                {
                    foreach (var st in Repository.GetList(new Stats()).Cast<Stats>().Where(st => st.Player.ID == updatedPlayer.ID))
                    {
                        Repository.Delete(st);
                    }
                }
            }

            Repository.Update(updatedPlayer);
        }
    }
}
