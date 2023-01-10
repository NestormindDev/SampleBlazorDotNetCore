using OrderManagement.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Service.Interface
{
    public interface ICityService
    {
        Task<ResponseModelDto<List<CityDto>>> GetById(int stateId);
    }
}
