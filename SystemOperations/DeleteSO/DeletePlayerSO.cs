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

            foreach(Stats st in repository.GetAll(new Stats()))
            {
                if(st.Player.ID == player.ID)
                {
                    repository.Delete(st);
                }
            }

            repository.Delete(player);
        }
    }
}
