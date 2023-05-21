using Domain;

namespace SystemOperations.AddSO
{
    public class AddGameSO : SystemOperationBase
    {
        private readonly Game g;

        public AddGameSO(Game g)
        {
            this.g = g;
        }
        
        protected override void Execute()
        {            
            repository.Add(g);            
        }
    }
}