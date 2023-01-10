using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.AggregatesModel
{
    public class City:Entity
    {
        public string Name { get; set; }
        public int? StateId { get; set; }
        public State State { get; set; }
        public Supplier  Supplier { get; set; }
    }
}
