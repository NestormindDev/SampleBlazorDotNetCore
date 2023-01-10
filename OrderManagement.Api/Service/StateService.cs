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
    public class StateService : IStateService
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper = null;
        public StateService(IStateRepository _stateRepository, IMapper _mapper)
        {
            stateRepository = _stateRepository;
            mapper = _mapper;
        }

       public async Task<ResponseModelDto<List<StateDto>>> GetAll()
        {
            ResponseModelDto<List<StateDto>> responseModelDto;
            try
            {
                var stateEntity = await stateRepository.GetAll();
                if (stateEntity.Count == 0)
                {
                    responseModelDto = ResponseModelDto<List<StateDto>>.GetResponseModel(Data: null, Message: Messages.NotFound, (int)Enumss.StatusCode.NotFound);
                }
                var statesDto = mapper.Map<List<StateDto>>(stateEntity);
                return ResponseModelDto<List<StateDto>>.GetResponseModel(Data: statesDto, Message: string.Empty, (int)Enumss.StatusCode.Ok);

            }
            catch (Exception ex)
            {
                responseModelDto = ResponseModelDto<List<StateDto>>.GetResponseModel(Data: null, Message: string.Empty, (int)Enumss.StatusCode.InternalServerError, Description: string.Empty, Records: null, Error: ex.Message);
            }
            return responseModelDto;
        }
    }
}
