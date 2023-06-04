using Domain;

namespace SystemOperations.AddSO
{
    public class AddTeamSO : SystemOperationBase
    {
        private readonly Team team;
        public AddTeamSO(Team team)
        {
            this.team = team;
        }
        protected override void Execute()
        {
            if (team.Name != null && team.City != null && team.Color != null)
                Repository.Add(team);
        }
    }
}
