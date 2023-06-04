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
            if (repository.GetObject(updatedPlayer) is Player upd)
            {
                updatedPlayer.Goals = upd.Goals;
            
                if(updatedPlayer.Team.ID != upd.Team.ID)
                {
                    foreach(Stats st in repository.GetAll(new Stats()))
                    {
                        if(st.Player.ID == updatedPlayer.ID)
                        {
                            repository.Delete(st);
                        }
                    }
                }
            }

            repository.Update(updatedPlayer);
        }
    }
}
