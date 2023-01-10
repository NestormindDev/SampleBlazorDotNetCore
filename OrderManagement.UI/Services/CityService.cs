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
    public class CityService: ICityService
    {
        private readonly HttpClient httpClient;
        public CityService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<ResponseDto<List<CityDto>>> GetById(int stateId)
        {
            var result= await httpClient.GetJsonAsync<ResponseDto<List<CityDto>>>("api/City/get/"+ stateId);
            return result;
        }
    }
}
