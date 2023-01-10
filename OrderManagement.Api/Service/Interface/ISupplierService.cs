using OrderManagement.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Service.Interface
{
    public interface ISupplierService
    {
        Task<ResponseModelDto<SupplierDto>> GetById(int id);
        Task<ResponseModelDto<List<SupplierDto>>> GetAll();
        Task<ResponseModelDto<bool>> Delete(int id);
        Task<ResponseModelDto<SupplierDto>> Add(SupplierDto addSupplierDto);
        Task<ResponseModelDto<bool>> Update(UpdateSupplierDto updateSupplierDto);
    }
}
