using Domain;

namespace SystemOperations
{
    public class AddPlayerSO : SystemOperationBase
    {
        private readonly Player player;
        public bool Result { get; private set; }

        public AddPlayerSO(Player p)
        {
            this.player = p;
        }

        protected override void Execute()
        {
            if (player.Name == null || player.Surname == null || player.Position == null || player.Country == null || player.Team == null ) 
                Result = false;

            Result = repository.Add(player);
        }
    }
}
