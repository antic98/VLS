using Domain;

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
            if (deletePlayer == null)
            {
                return;
            }

            if (deletePlayer.Stats != null)
            {
                foreach(Stats st in deletePlayer.Stats)
                {
                    if(st.Player.ID == deletePlayer.ID)
                    {
                        repository.Delete(st);
                    }
                }
            }

            repository.Delete(deletePlayer);
        }
    }
}
