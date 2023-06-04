using Domain;

namespace SystemOperations.AddSO
{
    public class AddPlayerSO : SystemOperationBase
    {
        private readonly Player player;

        public AddPlayerSO(Player player)
        {
            this.player = player;
        }

        protected override void Execute()
        {
            if (player.Name != null && player.Surname != null && player.Position != null && player.Country != null && player.Team != null) 
                Repository.Add(player);
        }
    }
}
