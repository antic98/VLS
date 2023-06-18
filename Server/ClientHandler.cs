using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using ApplicationLogic;
using Common;
using Domain;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private readonly CommunicationHelper helper;
        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        private bool end;

        public void HandleRequests()
        {
            try
            {
                while (!end)
                {
                    var request = helper.Receive<Request>();
                    var response = CreateResponse(request);
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

        private Response CreateResponse(Request request)
        {
            var response = new Response
            {
                IsSuccesful = true
            };

            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Login((User)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.IsSuccesful = false;
                            response.Message = "User doesn't exist.";
                        }
                        break;
                    case Operation.End:
                        end = true;
                        break;
                    case Operation.GetCountries:
                        response.Result = Controller.GetAllCountries();
                        break;
                    case Operation.GetPositions:
                        response.Result = Controller.GetAllPositions();
                        break;
                    case Operation.GetPlayers:
                        response.Result = Controller.GetAllPlayers();
                        break;
                    case Operation.GetTeams:
                        response.Result = Controller.GetAllTeams();
                        break;
                    case Operation.GetGames:
                        response.Result = Controller.GetAllGames();
                        break;
                    case Operation.GetStats:
                        response.Result = Controller.GetAllStats();
                        break;
                    case Operation.AddPlayer:
                        Controller.AddPlayer(request.RequestObject as Player);
                        break;
                    case Operation.AddTeam:
                        Controller.AddTeam(request.RequestObject as Team);
                        break;
                    case Operation.AddGame:
                        Controller.AddGame(request.RequestObject as Game);
                        break;
                    case Operation.SearchPlayers:
                        response.Result = Controller.SearchPlayer(request.RequestObject as Player);
                        break;
                    case Operation.SearchTeams:
                        response.Result = Controller.SearchTeam(request.RequestObject as Team);
                        break;
                    case Operation.SearchGames:
                        response.Result = Controller.SearchGame(request.RequestObject as Game);
                        break;
                    case Operation.DeletePlayer:
                        Controller.DeletePlayer(request.RequestObject as Player);
                        break;
                    case Operation.DeleteTeam:
                        Controller.DeleteTeam(request.RequestObject as Team);
                        break;
                    case Operation.DeleteGame:
                        Controller.DeleteGame(request.RequestObject as Game);
                        break;
                    case Operation.UpdatePlayer:
                        Controller.UpdatePlayer(request.RequestObject as Player);
                        break;
                    case Operation.UpdateTeam:
                        Controller.UpdateTeam(request.RequestObject as Team);
                        break;
                    case Operation.UpdateGame:
                        Controller.UpdateGame(request.RequestObject as Game);
                        break;
                    case Operation.AddGamesSingle:
                        Controller.AddGamesSingle(request.RequestObject as List<Team>);
                        break;
                    case Operation.AddGamesDouble:
                        Controller.AddGamesDouble(request.RequestObject as List<Team>);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
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
                if (socket == null) return;
                end = true;                
                socket.Shutdown(SocketShutdown.Both);                
                socket.Close();                
                socket = null; 
                OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
            }
        }


    }
}
