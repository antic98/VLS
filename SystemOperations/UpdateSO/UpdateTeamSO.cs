using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UpdateSO
{
    public class UpdateTeamSO : SystemOperationBase
    {
        private Team updatedTeam;

        public UpdateTeamSO(Team updatedTeam)
        {
            this.updatedTeam = updatedTeam;
        }

        protected override void Execute()
        {
            Team upd = repository.GetObject(updatedTeam) as Team;
            upd.Name = updatedTeam.Name;
            upd.City = updatedTeam.City;
            upd.Color = updatedTeam.Color;

            repository.Update(upd);
        }
    }
}
