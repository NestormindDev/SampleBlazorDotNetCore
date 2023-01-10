using AutoMapper;
using OrderManagement.Api.ConstantMessage;
using OrderManagement.Api.Dto;
using OrderManagement.Api.Enums;
using OrderManagement.Api.Service.Interface;
using OrderManagement.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Service
{
    public class CityService : ICityService
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper = null;
        public CityService(ICityRepository _cityRepository, IMapper _mapper)
        {
            cityRepository = _cityRepository;
            mapper = _mapper;
        }

       public async Task<ResponseModelDto<List<CityDto>>> GetById(int stateId)
        {
            ResponseModelDto<List<CityDto>> responseModelDto;
            try
            {
                var cityEntity = await cityRepository.FilterExpressionRangeAsync(f => f.StateId == stateId,null);
                if (cityEntity.Count == 0)
                {
                    responseModelDto = ResponseModelDto<List<CityDto>>.GetResponseModel(Data: null, Message: Messages.NotFound, (int)Enumss.StatusCode.NotFound);
                }
                var citiesDto = mapper.Map<List<CityDto>>(cityEntity);
                return ResponseModelDto<List<CityDto>>.GetResponseModel(Data: citiesDto, Message: string.Empty, (int)Enumss.StatusCode.Ok);
            }
            catch (Exception ex)
            {
                responseModelDto = ResponseModelDto<List<CityDto>>.GetResponseModel(Data: null, Message: string.Empty, (int)Enumss.StatusCode.InternalServerError, Description: string.Empty, Records: null, Error: ex.Message);
            }
            return responseModelDto;
        }
    }
}
