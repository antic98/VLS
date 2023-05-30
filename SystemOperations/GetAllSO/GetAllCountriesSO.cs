using System.Collections.Generic;
using System.Linq;
using Domain;

namespace SystemOperations.GetSO
{
    public class GetAllCountriesSO : SystemOperationBase
    {
        public List<Country> Result { get; private set; }
        protected override void Execute()
        {
            Result = repository.GetAll(new Country()).OfType<Country>().ToList();
        }
    }
}
