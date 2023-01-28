using Core.Concrate.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract.Services
{
    public interface ISalesService
    {
        IEnumerable<SalesPersonSimpleDTO> GetSalesPeople();
        SalesPersonDetailedDTO GetSalesPerson();
    }
}
