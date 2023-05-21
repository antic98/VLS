using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private CommunicationHelper helper;
        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        private bool kraj = false;

        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }

        public Response CreateResponse(Request request)
        {
            Response response = new Response();
            response.IsSuccesful = true;

            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = ApplicationLogic.Controller.Instance.Login((User)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.IsSuccesful = false;
                            response.Message = "User doesn't exist.";
                        }
                        break;
                    case Operation.Kraj:
                        kraj = true;
                        break;
                    case Operation.GetCountries:
                        response.Result = ApplicationLogic.Controller.Instance.GetAllCountries();
                        break;
                    case Operation.GetPositions:
                        response.Result = ApplicationLogic.Controller.Instance.GetAllPositions();
                        break;
                    case Operation.GetPlayers:
                        response.Result = ApplicationLogic.Controller.Instance.GetAllPlayers();
                        break;
                    case Operation.GetTeams:
                        response.Result = ApplicationLogic.Controller.Instance.GetAllTeams();
                        break;
                    case Operation.GetGames:
                        response.Result = ApplicationLogic.Controller.Instance.GetAllGames();
                        break;
                    case Operation.GetStats:
                        response.Result = ApplicationLogic.Controller.Instance.GetAllStats();
                        break;
                    case Operation.SavePlayer:
                        ApplicationLogic.Controller.Instance.AddPlayer(request.RequestObject as Player);
                        break;
                    case Operation.SaveTeam:
                        ApplicationLogic.Controller.Instance.AddTeam(request.RequestObject as Team);
                        break;
                    case Operation.SaveGame:
                        ApplicationLogic.Controller.Instance.AddGame(request.RequestObject as Game);
                        break;
                    case Operation.SearchPlayers:
                        response.Result = ApplicationLogic.Controller.Instance.SearchPlayer(request.RequestObject as Player);
                        break;
                    case Operation.SearchTeams:
                        response.Result = ApplicationLogic.Controller.Instance.SearchTeam(request.RequestObject as Team);
                        break;
                    case Operation.SearchGames:
                        response.Result = ApplicationLogic.Controller.Instance.SearchGame(request.RequestObject as Game);
                        break;
                    case Operation.DeletePlayer:
                        ApplicationLogic.Controller.Instance.DeletePlayer(request.RequestObject as Player);
                        break;
                    case Operation.DeleteTeam:
                        ApplicationLogic.Controller.Instance.DeleteTeam(request.RequestObject as Team);
                        break;
                    case Operation.DeleteGame:
                        ApplicationLogic.Controller.Instance.DeleteGame(request.RequestObject as Game);
                        break;
                    case Operation.UpdatePlayer:
                        ApplicationLogic.Controller.Instance.UpdatePlayer(request.RequestObject as Player);
                        break;
                    case Operation.UpdateTeam:
                        ApplicationLogic.Controller.Instance.UpdateTeam(request.RequestObject as Team);
                        break;
                    case Operation.UpdateGame:
                        ApplicationLogic.Controller.Instance.UpdateGame(request.RequestObject as Game);
                        break;
                    case Operation.AddGamesSingle:
                        ApplicationLogic.Controller.Instance.AddGamesSingle(request.RequestObject as List<Team>);
                        break;
                    case Operation.AddGamesDouble:
                        ApplicationLogic.Controller.Instance.AddGamesDouble(request.RequestObject as List<Team>);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
                response.IsSuccesful = false;
                response.Message = ex.Message;
            }
            return response;
        }

        private object lockobject = new object();

        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if(socket != null)
                {                      
                    kraj = true;                
                    socket.Shutdown(SocketShutdown.Both);                
                    socket.Close();                
                    socket = null; 
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }


    }
}
