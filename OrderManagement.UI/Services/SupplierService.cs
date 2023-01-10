using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using OrderManagement.UI.Dto;
using OrderManagement.UI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OrderManagement.UI.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly HttpClient httpClient;
        public SupplierService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }


        public async Task<ResponseDto<List<SupplierDto>>> GetAll()
        {
            return await httpClient.GetJsonAsync<ResponseDto<List<SupplierDto>>>("api/Supplier/getAll");
        }
        public async Task<ResponseDto<SupplierDto>> GetById(int id)
        {
            var result= await httpClient.GetJsonAsync<ResponseDto<SupplierDto>>("api/Supplier/getById/"+id);
            return result;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await httpClient.DeleteAsync("api/Supplier/delete/" + id);
            if (!result.IsSuccessStatusCode)
            {
                return false;
            }
            return true;
        }

        public async Task<ResponseDto<SupplierDto>> Add(SupplierDto addSupplierDto)
        {
            var supplier = System.Text.Json.JsonSerializer.Serialize(addSupplierDto);
            var requestContent = new StringContent(supplier, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/Supplier/add/", requestContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result= System.Text.Json.JsonSerializer.Deserialize<ResponseDto<SupplierDto>>(content);
            return result;
        }
        public async Task<ResponseDto<bool>> Update(UpdateSupplierDto editSupplierDto)
        {

            var supplier = System.Text.Json.JsonSerializer.Serialize(editSupplierDto);
            var requestContent = new StringContent(supplier, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("/api/Supplier/update/", requestContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = System.Text.Json.JsonSerializer.Deserialize<ResponseDto<bool>>(content);
            return result;
        }
    }
}
