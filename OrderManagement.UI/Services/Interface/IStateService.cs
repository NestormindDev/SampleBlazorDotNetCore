using OrderManagement.UI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.UI.Services.Interface
{
    public interface IStateService
    {
        Task<ResponseDto<List<StateDto>>> GetAll();
    }
}
