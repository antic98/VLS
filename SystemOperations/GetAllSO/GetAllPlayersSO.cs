﻿using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetAllSO
{
    public class GetAllPlayersSO : SystemOperationBase
    {
        public List<Player> Result { get; private set; }
        protected override void Execute()
        {
            Result = Repository.GetList(new Player()).OfType<Player>().ToList();
        }
    }
}
