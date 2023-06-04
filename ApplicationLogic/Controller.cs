using Domain;
using System.Collections.Generic;
using System.Linq;
using SystemOperations;
using SystemOperations.AddSO;
using SystemOperations.DeleteSO;
using SystemOperations.GetAllSO;
using SystemOperations.SearchSO;
using SystemOperations.UpdateSO;

namespace ApplicationLogic
{
    public class Controller
    {
        #region SINGLETON
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {                
                if (_instance == null)               
                {                       
                    if (_instance == null) _instance = new Controller();                    
                }
                return _instance;
            }
        }
        private Controller()
        {

        }
        #endregion
                
        
        //ADD

        public static void AddPlayer(Player newPlayer)
        {
            SystemOperationBase so = new AddPlayerSO(newPlayer);
            so.ExecuteTemplate();
        }
        public static void AddTeam(Team newTeam)
        {
            SystemOperationBase so = new AddTeamSO(newTeam);
            so.ExecuteTemplate();
        }
        public static void AddGame(Game newGame)
        {
            SystemOperationBase so = new AddGameSO(newGame);
            so.ExecuteTemplate();
        }
        public static void AddGamesSingle(List<Team> teams)
        {
            SystemOperationBase so = new AddGamesSingleSO(teams);
            so.ExecuteTemplate();
        }

        public static void AddGamesDouble(List<Team> teams)
        {
            SystemOperationBase so = new AddGamesDoubleSO(teams);
            so.ExecuteTemplate();
        }

        //GETALL

        public static List<Player> GetAllPlayers()
        {
            SystemOperationBase so = new GetAllPlayersSO();
            so.ExecuteTemplate();
            return ((GetAllPlayersSO)so).Result;
        }
        public static List<Team> GetAllTeams()
        {
            SystemOperationBase so = new GetAllTeamsSO();
            so.ExecuteTemplate();
            return ((GetAllTeamsSO)so).Result;
        }
        public static List<Country> GetAllCountries()
        {
            SystemOperationBase so = new GetAllCountriesSO();
            so.ExecuteTemplate();
            return ((GetAllCountriesSO)so).Result;
        }
        public static List<Game> GetAllGames()
        {
            SystemOperationBase so = new GetAllGamesSO();
            so.ExecuteTemplate();
            return ((GetAllGamesSO)so).Result;
        }
        public static List<Position> GetAllPositions()
        {
            SystemOperationBase so = new GetAllPositionsSO();
            so.ExecuteTemplate();
            return ((GetAllPositionsSO)so).Result;
        }
        public static List<Stats> GetAllStats()
        {
            SystemOperationBase so = new GetAllStatsSO();
            so.ExecuteTemplate();
            return ((GetAllStatsSO)so).Result;
        }

        //UPDATE

        public static void UpdatePlayer(Player updatedPlayer)
        {
            SystemOperationBase so = new UpdatePlayerSO(updatedPlayer);
            so.ExecuteTemplate();
        }
        public static void UpdateTeam(Team updatedTeam)
        {
            SystemOperationBase so = new UpdateTeamSO(updatedTeam);
            so.ExecuteTemplate();
        }
        public static void UpdateGame(Game updatedGame)
        {
            SystemOperationBase so = new UpdateGameSO(updatedGame);
            so.ExecuteTemplate();
        }

        //DELETE

        public static void DeletePlayer(Player deletePlayer)
        {
            SystemOperationBase so = new DeletePlayerSO(deletePlayer);
            so.ExecuteTemplate();
        }
        public static void DeleteTeam(Team deleteTeam)
        {
            SystemOperationBase so = new DeleteTeamSO(deleteTeam);
            so.ExecuteTemplate();
        }
        public static void DeleteGame(Game deleteGame)
        {
            SystemOperationBase so = new DeleteGameSO(deleteGame);
            so.ExecuteTemplate();
        }

        //SEARCH

        public static List<Player> SearchPlayer(Player player)
        {
            SystemOperationBase so = new SearchPlayerSO(player);
            so.ExecuteTemplate();
            return ((SearchPlayerSO)so).Result;
        }
        public static List<Team> SearchTeam(Team team)
        {
            SystemOperationBase so = new SearchTeamSO(team);
            so.ExecuteTemplate();
            return ((SearchTeamSO)so).Result;
        }
        public static List<Game> SearchGame(Game game)
        {
            SystemOperationBase so = new SearchGameSO(game);
            so.ExecuteTemplate();
            return ((SearchGameSO)so).Result;
        }

        //LOGIN

        public static User Login(User u)
        {
            SystemOperationBase so = new GetAllUsersSO();
            so.ExecuteTemplate();
            var users = ((GetAllUsersSO)so).Result;

            return users.FirstOrDefault(user => user.Username == u.Username && user.Password == u.Password);
        }
    }
}
