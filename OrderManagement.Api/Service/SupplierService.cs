using AutoMapper;
using OrderManagement.Api.ConstantMessage;
using OrderManagement.Api.Dto;
using OrderManagement.Domain.AggregatesModel;
using OrderManagement.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderManagement.Api.Enums;

namespace OrderManagement.Api.Service.Interface
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;
        private readonly IMapper mapper = null;
        public SupplierService(ISupplierRepository _supplierRepository, IMapper _mapper)
        {
            supplierRepository = _supplierRepository;
            mapper = _mapper;
        }

        public async Task<ResponseModelDto<List<SupplierDto>>> GetAll()
        
        {
            ResponseModelDto<List<SupplierDto>> responseModelDto;
            try
            {
                var supplierEntity = await supplierRepository.FilterExpressionRangeAsync(null, new string[] { "State", "City" });
                if (supplierEntity.Count == 0)
                {
                    responseModelDto = ResponseModelDto<List<SupplierDto>>.GetResponseModel(Data: null, Message: Messages.NotFound, (int)Enumss.StatusCode.NotFound);
                }
                var suppliersDto = mapper.Map<List<SupplierDto>>(supplierEntity);
                return ResponseModelDto<List<SupplierDto>>.GetResponseModel(Data: suppliersDto, Message: string.Empty, (int)Enumss.StatusCode.Ok);
            }
            catch (Exception ex)
            {
                responseModelDto = ResponseModelDto<List<SupplierDto>>.GetResponseModel(Data: null, Message: string.Empty, (int)Enumss.StatusCode.InternalServerError, Description: string.Empty, Records: null, Error: ex.Message);
            }
            return responseModelDto;
        }
        public async Task<ResponseModelDto<SupplierDto>> GetById(int id)
        {
            ResponseModelDto<SupplierDto> responseModelDto;
            try
            {
                var supplierEntity = await supplierRepository.GetById(id);
                if (supplierEntity == null)
                {

                    return ResponseModelDto<SupplierDto>.GetResponseModel(Data: null, Message: Messages.NotFound, (int)Enumss.StatusCode.NotFound);
                }
                var supplierDto = mapper.Map<SupplierDto>(supplierEntity);
                return ResponseModelDto<SupplierDto>.GetResponseModel(Data: supplierDto, Message: string.Empty, (int)Enumss.StatusCode.Ok);
            }
            catch (Exception ex)
            {
                responseModelDto = ResponseModelDto<SupplierDto>.GetResponseModel(Data: null, Message: string.Empty, (int)Enumss.StatusCode.InternalServerError, Description: string.Empty, Records: null, Error: ex.Message);
            }
            return responseModelDto;

        }
        public async Task<ResponseModelDto<bool>> Update(UpdateSupplierDto updateSupplierDto)
        {
            ResponseModelDto<bool> responseModelDto;
            try
            {
                Supplier supplierEntity = new(updateSupplierDto.SupplierName,
                updateSupplierDto.AddressLine1, updateSupplierDto.AddressLine2, updateSupplierDto.PostalCode, updateSupplierDto.StateId,
                updateSupplierDto.CityId);
                supplierEntity.Id = updateSupplierDto.Id;
                supplierRepository.Update(supplierEntity);
                var result = await supplierRepository.UnitOfWork.Save();
                if (!result)
                {
                    return ResponseModelDto<Boolean>.GetResponseModel(Data: false, Message: Messages.FailUpdate, (int)Enumss.StatusCode.BadRequest);
                }
                //supplierEntity = await supplierRepository.FilterExpressionAsync(c => c.Id == supplierEntity.Id, new string[] { "State", "City" });
                //var supplierUpdateDto = this.mapper.Map<UpdateSupplierDto>(supplierEntity);
                return ResponseModelDto<Boolean>.GetResponseModel(Data: true, Message: Messages.Update, (int)Enumss.StatusCode.Ok);
            }
            catch (Exception ex)
            {
                responseModelDto = ResponseModelDto<bool>.GetResponseModel(Data: false, Message: string.Empty, (int)Enumss.StatusCode.InternalServerError, Description: string.Empty, Records: null, Error: ex.Message);
            }
            return responseModelDto;
        }
        public async Task<ResponseModelDto<bool>> Delete(int id)
        {
            ResponseModelDto<bool> responseModelDto;
            try
            {
                var supplierEntity = await supplierRepository.GetById(id);
                if (supplierEntity == null)
                {
                    return ResponseModelDto<bool>.GetResponseModel(Data: false, Message: Messages.NotFound, (int)Enumss.StatusCode.NotFound);
                }
                supplierRepository.Remove(supplierEntity);
                var result = await supplierRepository.UnitOfWork.Save();
                if (!result)
                {
                    return ResponseModelDto<bool>.GetResponseModel(Data: false, Message: Messages.FailDelete, (int)Enumss.StatusCode.BadRequest);
                }
                return ResponseModelDto<bool>.GetResponseModel(Data: true, Message: Messages.Delete, (int)Enumss.StatusCode.Ok);
            }
            catch (Exception ex)
            {
                responseModelDto = ResponseModelDto<bool>.GetResponseModel(Data: false, Message: string.Empty, (int)Enumss.StatusCode.InternalServerError, Description: string.Empty, Records: null, Error: ex.Message);
            }
            return responseModelDto;
        }

        public async Task<ResponseModelDto<SupplierDto>> Add(SupplierDto addSupplierDto)
        {
            ResponseModelDto<SupplierDto> responseModelDto;
            try
            {
                Supplier supplierEntity = new(addSupplierDto.SupplierName,
                addSupplierDto.AddressLine1, addSupplierDto.AddressLine2, addSupplierDto.PostalCode, addSupplierDto.StateId,
                addSupplierDto.CityId);
                await supplierRepository.AddAsync(supplierEntity);
                var result = await supplierRepository.UnitOfWork.Save();
                if (!result)
                {
                    return ResponseModelDto<SupplierDto>.GetResponseModel(Data: null, Message: Messages.FailAdd, (int)Enumss.StatusCode.BadRequest);
                }
                //supplierEntity = await supplierRepository.FilterExpressionAsync(c => c.Id == supplierEntity.Id, new string[] { "State", "City" });
                var supplierDto = this.mapper.Map<SupplierDto>(supplierEntity);
                return ResponseModelDto<SupplierDto>.GetResponseModel(Data: supplierDto, Message: Messages.Add, (int)Enumss.StatusCode.Ok);
            }
            catch (Exception ex)
            {
                responseModelDto = ResponseModelDto<SupplierDto>.GetResponseModel(Data: null, Message: string.Empty, (int)Enumss.StatusCode.InternalServerError, Description: string.Empty, Records: null, Error: ex.Message);
            }
            return responseModelDto;
        }
    }
}
