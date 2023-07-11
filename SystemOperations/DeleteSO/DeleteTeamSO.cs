using System.Linq;
using Domain;

namespace SystemOperations.DeleteSO
{
    public class DeleteTeamSO : SystemOperationBase
    {
        private readonly Team team;

        public DeleteTeamSO(Team team)
        {
            this.team = team;
        }

        protected override void Execute()
        {
            if (team == null)
            {
                return;
            }

            var allStats = Repository.GetList(new Stats());
            
            foreach (var g in Repository.GetList(new Game()).Cast<Game>().Where(g => g.Host.ID == team.ID || g.Guest.ID == team.ID))
            {
                foreach (var o in allStats)
                {
                    var st = (Stats)o;
                    if (st.Game.ID != g.ID) continue;
                    var p = Repository.GetObject(st.Player) as Player;
                    if (p == null) continue;
                    p.Goals -= st.Goals;

                    Repository.Delete(st);

                    if (p.Team.ID != team.ID)
                        Repository.Update(p);
                }

                var host = Repository.GetObject(g.Host) as Team;
                host.GoalsScored -= g.GoalsHost;
                host.GoalsConceded -= g.GoalsGuest;

                var guest = Repository.GetObject(g.Guest) as Team;
                guest.GoalsScored -= g.GoalsGuest;
                guest.GoalsConceded -= g.GoalsHost;

                if (g.GoalsHost > g.GoalsGuest)
                {
                    host.Points -= 3;
                    host.Wins -= 1;
                    guest.Loses -= 1;
                }
                if (g.GoalsHost < g.GoalsGuest)
                {
                    guest.Points -= 3;
                    guest.Wins -= 1;
                    host.Loses -= 1;
                }
                if (g.GoalsHost == g.GoalsGuest)
                {
                    host.Points -= 1;
                    guest.Points -= 1;
                    host.Draws -= 1;
                    guest.Draws -= 1;
                }

                Repository.Delete(g);

                if (g.Host.ID == team.ID)
                    Repository.Update(guest);
                if (g.Guest.ID == team.ID) 
                    Repository.Update(host);
            }

            foreach (var pl in Repository.GetList(new Player()).Cast<Player>().Where(pl => pl.Team.ID == team.ID))
            {
                Repository.Delete(pl);
            }

            Repository.Delete(team);
        }
    }
}
