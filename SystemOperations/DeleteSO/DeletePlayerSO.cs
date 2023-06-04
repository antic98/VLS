using Domain;

namespace SystemOperations.DeleteSO
{
    public class DeletePlayerSO : SystemOperationBase
    {
        private readonly Player player;

        public DeletePlayerSO(Player player)
        {
            this.player = player;
        }

        protected override void Execute()
        {
            if (player == null)
            {
                return;
            }

            foreach(Stats st in Repository.GetAll(new Stats()))
            {
                if(st.Player.ID == player.ID)
                {
                    Repository.Delete(st);
                }
            }

            Repository.Delete(player);
        }
    }
}
