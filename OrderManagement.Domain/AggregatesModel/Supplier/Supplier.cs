using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.AggregatesModel
{
    public class Supplier: Entity
    {
        public string SupplierName { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string PostalCode { get; private set; }
        /// <summary>
        // define one to one relationship with State
        /// </summary>
        public State State { get; set; }
        public int? StateId { get; private set; }
        /// <summary>
        // define one to one relationship with City
        /// </summary>
        public int? CityId { get; private set; }
        public City City { get; set; } 
        
        public Supplier(string supplierName, string addressLine1,string addressLine2,string postalCode, int? stateId,int? cityId)
        {
            SupplierName = supplierName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            PostalCode = postalCode;
            StateId = stateId;
            CityId = cityId;
        }
    }
}
