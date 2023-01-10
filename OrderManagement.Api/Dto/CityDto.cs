using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Dto
{
    public class CityDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? StateId { get; set; }
        public StateDto StateDto { get; set; }
       
    }
}
