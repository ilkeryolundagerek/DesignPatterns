using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrate.DTOs
{
    public class SalesPersonSimpleDTO
    {
        public int BusinessEntityID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Territory { get; set; }
        public string CountryRegionCode { get; set; }
        public decimal SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal Commission { get; set; }
    }

    public class SalesPersonDetailedDTO
    {
        public int BusinessEntityID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Territory { get; set; }
        public string CountryRegionCode { get; set; }
        public decimal SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal Commission { get; set; }
    }
}
