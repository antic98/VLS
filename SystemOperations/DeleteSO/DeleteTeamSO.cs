﻿using Domain;

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
            
            foreach (Game g in repository.GetAll(new Game()))
            {
                if(g.Host.ID == team.ID || g.Guest.ID == team.ID)
                {
                    foreach (Stats st in repository.GetAll(new Stats()))
                    {
                        if (st.Game.ID == g.ID)
                        {
                            Player p = repository.GetObject(st.Player) as Player;
                            p.Goals -= st.Goals;

                            repository.Delete(st);

                            if (p.Team.ID != team.ID)
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

                    if (g.Host.ID == team.ID)
                    {
                        repository.Update(guest);
                    }
                    if (g.Guest.ID == team.ID)
                    {
                        repository.Update(host);
                    }
                }
            }

            foreach (Player pl in repository.GetAll(new Player()))
            {
                if (pl.Team.ID == team.ID)
                    repository.Delete(pl);
            }

            repository.Delete(team);
        }
    }
}
