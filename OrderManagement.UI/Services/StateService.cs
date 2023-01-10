using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OrderManagement.UI.Dto;
using OrderManagement.UI.Services.Interface;

namespace OrderManagement.UI.Services
{
    public class StateService: IStateService
    {
        private readonly HttpClient httpClient;
        public StateService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<ResponseDto<List<StateDto>>> GetAll()
        {
            var result= await httpClient.GetJsonAsync<ResponseDto<List<StateDto>>>("api/State/getAll");
            return result;
        }
    }
}
