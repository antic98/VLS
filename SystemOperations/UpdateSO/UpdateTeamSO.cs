using Domain;

namespace SystemOperations.UpdateSO
{
    public class UpdateTeamSO : SystemOperationBase
    {
        private readonly Team updatedTeam;

        public UpdateTeamSO(Team updatedTeam)
        {
            this.updatedTeam = updatedTeam;
        }

        protected override void Execute()
        {
            Team upd = Repository.GetObject(updatedTeam) as Team;
            upd.Name = updatedTeam.Name;
            upd.City = updatedTeam.City;
            upd.Color = updatedTeam.Color;

            Repository.Update(upd);
        }
    }
}
