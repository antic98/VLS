using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetAllSO
{
    public class GetAllCountriesSO : SystemOperationBase
    {
        public List<Country> Result { get; private set; }
        protected override void Execute()
        {
            Result = Repository.GetList(new Country()).OfType<Country>().ToList();
        }
    }
}
