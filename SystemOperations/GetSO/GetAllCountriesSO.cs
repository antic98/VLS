﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
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