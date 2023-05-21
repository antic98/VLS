using Domain;

namespace SystemOperations.DeleteSO
{
    public class DeleteTeamSO : SystemOperationBase
    {
        private Team deleteTeam;

        public DeleteTeamSO(Team deleteTeam)
        {
            this.deleteTeam = deleteTeam;
        }

        protected override void Execute()
        {
            foreach (Game g in deleteTeam.Games)
            {
                if(g.Host.ID == deleteTeam.ID || g.Guest.ID == deleteTeam.ID)
                {
                    foreach (Stats st in deleteTeam.Stats)
                    {
                        if (st.Game.ID == g.ID)
                        {
                            Player p = repository.GetObject(st.Player) as Player;
                            p.Goals -= st.Goals;

                            repository.Delete(st);

                            if (p.Team.ID != deleteTeam.ID)
                                repository.Update(p);
                        }
                    }

                    Team host = repository.GetObject(g.Host) as Team;
                    host.GoalsScored -= g.GoalsHost;
                    host.GoalsConceded -= g.GoalsGuest;

                    Team guest = repository.GetObject(g.Guest) as Team;
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

                    repository.Delete(g);

                    if (g.Host.ID == deleteTeam.ID)
                    {
                        repository.Update(guest);
                    }
                    if (g.Guest.ID == deleteTeam.ID)
                    {
                        repository.Update(host);
                    }
                }
            }

            foreach (Player pl in deleteTeam.Players)
            {
                if (pl.Team.ID == deleteTeam.ID)
                    repository.Delete(pl);
            }

            repository.Delete(deleteTeam);
        }
    }
}
