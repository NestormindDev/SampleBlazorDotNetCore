using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.UI.Dto
{
    public class SupplierDto
    {
        public int? Id { get; set; }
        public string SupplierName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public StateDto StateDto { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public CityDto CityDto { get; set; }
    }
}
