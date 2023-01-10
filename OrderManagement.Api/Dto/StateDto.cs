using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Dto
{
    public class StateDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public List<CityDto> CityDto { get; set; }
    }
}
