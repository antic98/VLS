using Domain;

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
