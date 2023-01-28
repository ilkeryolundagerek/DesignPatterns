using Core.Abstract.Repositories;
using Core.Abstract.Services;
using Core.Concrate.DTOs;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SalesService : ISalesService
    {
        private IPersonRepository personRepository;
        private ISalesPersonRepository salesPersonRepository;
        private ISalesTerritoryRepository salesTerritoryRepository;

        public SalesService()
        {
            personRepository = new PersonRepository();
            salesPersonRepository = new SalesPersonRepository();
            salesTerritoryRepository = new SalesTerritoryRepository();
        }

        public IEnumerable<SalesPersonSimpleDTO> GetSalesPeople()
        {
            throw new NotImplementedException();
        }

        public SalesPersonDetailedDTO GetSalesPerson()
        {
            throw new NotImplementedException();
        }
    }
}
