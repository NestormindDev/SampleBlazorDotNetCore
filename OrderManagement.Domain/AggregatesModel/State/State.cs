using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.AggregatesModel
{
    public class State:Entity
    {
        public string Name { get; set; }

        // define one to many relationship with City
        public ICollection<City> City { get; set; }

        // define one to one relationship with Supplier
        public Supplier Supplier { get; set; }
    }
}
