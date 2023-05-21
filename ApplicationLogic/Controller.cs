using Domain;
using System.Collections.Generic;
using SystemOperations;
using SystemOperations.AddSO;
using SystemOperations.DeleteSO;
using SystemOperations.GetSO;
using SystemOperations.SearchSO;
using SystemOperations.UpdateSO;

namespace ApplicationLogic
{
    public class Controller
    {
        #region SINGLETON
        private static Controller instance;
        public static Controller Instance
        {
            get
            {                
                if (instance == null)               
                {                       
                    if (instance == null) instance = new Controller();                    
                }
                return instance;
            }
        }
        private Controller()
        {

        }
        #endregion
                
        
        //ADD

        public void AddPlayer(Player newPlayer)
        {
            SystemOperationBase so = new AddPlayerSO(newPlayer);
            so.ExecuteTemplate();
        }
        public void AddTeam(Team newTeam)
        {
            SystemOperationBase so = new AddTeamSO(newTeam);
            so.ExecuteTemplate();
        }
        public void AddGame(Game newGame)
        {
            SystemOperationBase so = new AddGameSO(newGame);
            so.ExecuteTemplate();
        }
        public void AddGamesSingle(List<Team> teams)
        {
            SystemOperationBase so = new AddGamesSingleSO(teams);
            so.ExecuteTemplate();
        }

        public void AddGamesDouble(List<Team> teams)
        {
            SystemOperationBase so = new AddGamesDoubleSO(teams);
            so.ExecuteTemplate();
        }

        //GETALL

        public List<Player> GetAllPlayers()
        {
            SystemOperationBase so = new GetAllPlayersSO();
            so.ExecuteTemplate();
            return ((GetAllPlayersSO)so).Result;
        }
        public List<Team> GetAllTeams()
        {
            SystemOperationBase so = new GetAllTeamsSO();
            so.ExecuteTemplate();
            return ((GetAllTeamsSO)so).Result;
        }
        public List<Country> GetAllCountries()
        {
            SystemOperationBase so = new GetAllCountriesSO();
            so.ExecuteTemplate();
            return ((GetAllCountriesSO)so).Result;
        }
        public List<Game> GetAllGames()
        {
            SystemOperationBase so = new GetAllGamesSO();
            so.ExecuteTemplate();
            return ((GetAllGamesSO)so).Result;
        }
        public List<Position> GetAllPositions()
        {
            SystemOperationBase so = new GetAllPositionsSO();
            so.ExecuteTemplate();
            return ((GetAllPositionsSO)so).Result;
        }
        public List<Stats> GetAllStats()
        {
            SystemOperationBase so = new GetAllStatsSO();
            so.ExecuteTemplate();
            return ((GetAllStatsSO)so).Result;
        }

        //UPDATE

        public void UpdatePlayer(Player updatedPlayer)
        {
            SystemOperationBase so = new UpdatePlayerSO(updatedPlayer);
            so.ExecuteTemplate();
        }
        public void UpdateTeam(Team updatedTeam)
        {
            SystemOperationBase so = new UpdateTeamSO(updatedTeam);
            so.ExecuteTemplate();
        }
        public void UpdateGame(Game updatedGame)
        {
            SystemOperationBase so = new UpdateGameSO(updatedGame);
            so.ExecuteTemplate();
        }

        //DELETE

        public void DeletePlayer(Player deletePlayer)
        {
            SystemOperationBase so = new DeletePlayerSO(deletePlayer);
            so.ExecuteTemplate();
        }
        public void DeleteTeam(Team deleteTeam)
        {
            SystemOperationBase so = new DeleteTeamSO(deleteTeam);
            so.ExecuteTemplate();
        }
        public void DeleteGame(Game deleteGame)
        {
            SystemOperationBase so = new DeleteGameSO(deleteGame);
            so.ExecuteTemplate();
        }

        //SEARCH

        public List<Player> SearchPlayer(Player player)
        {
            SystemOperationBase so = new SearchPlayerSO(player);
            so.ExecuteTemplate();
            return ((SearchPlayerSO)so).Result;
        }
        public List<Team> SearchTeam(Team team)
        {
            SystemOperationBase so = new SearchTeamSO(team);
            so.ExecuteTemplate();
            return ((SearchTeamSO)so).Result;
        }
        public List<Game> SearchGame(Game game)
        {
            SystemOperationBase so = new SearchGameSO(game);
            so.ExecuteTemplate();
            return ((SearchGameSO)so).Result;
        }

        //LOGIN

        public User Login(User u)
        {
            SystemOperationBase so = new GetAllUsersSO();
            so.ExecuteTemplate();
            List<User> users = ((GetAllUsersSO)so).Result;

            foreach (User user in users)
            {
                if (user.Username == u.Username && user.Password == u.Password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
