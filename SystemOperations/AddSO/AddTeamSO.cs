using Domain;

namespace SystemOperations
{
    public class AddTeamSO : SystemOperationBase
    {
        private readonly Team team;
        public AddTeamSO(Team t)
        {
            this.team = t;
        }
        protected override void Execute()
        {
            repository.Add(team);
        }
    }
}
