﻿using Domain;

namespace SystemOperations.AddSO
{
    public class AddGameSO : SystemOperationBase
    {
        private readonly Game game;

        public AddGameSO(Game game)
        {
            this.game = game;
        }
        
        protected override void Execute()
        {
            if (game?.Host == null || game.Guest == null) return;
            
            game.GoalsHost = -1;
            game.GoalsGuest = -1;
            game.DateString = game.Date.ToString("yyyy-MM-dd HH:mm");

            Repository.Add(game);
        }
    }
}