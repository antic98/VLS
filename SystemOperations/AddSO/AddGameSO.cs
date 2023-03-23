using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AddSO
{
    public class AddGameSO : SystemOperationBase
    {
        private readonly Game g;

        public AddGameSO(Game g)
        {
            this.g = g;
        }
        
        protected override void Execute()
        {            
            repository.Add(g);            
        }
    }
}