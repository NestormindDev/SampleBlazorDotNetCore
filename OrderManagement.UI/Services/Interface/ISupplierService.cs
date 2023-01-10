using OrderManagement.UI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.UI.Services.Interface
{
    public interface ISupplierService
    {
        Task<ResponseDto<List<SupplierDto>>> GetAll();
        Task<ResponseDto<SupplierDto>> GetById(int id);
        Task<ResponseDto<SupplierDto>> Add(SupplierDto addSupplierDto);
        Task<ResponseDto<bool>> Update(UpdateSupplierDto editSupplierDto);
        Task<bool> Delete(int id);
    }
}
