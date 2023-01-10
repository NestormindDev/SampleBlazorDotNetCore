using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Api.Dto;
using OrderManagement.Api.Service.Interface;
using OrderManagement.Domain.AggregatesModel;
using OrderManagement.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService  supplierService;
        public SupplierController(ISupplierService _supplierService)
        {
            supplierService = _supplierService;
        }

        [Route("getAll")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result =  await this.supplierService.GetAll();
            return Ok(result);
        }
        [Route("getById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await this.supplierService.GetById(id);
            return Ok(result);
        }
        [Route("add")]
        [HttpPost]
        public async Task<IActionResult> Add(SupplierDto  addSupplierDto)
        {
            var result = await this.supplierService.Add(addSupplierDto);
            return Ok(result);
        }
        [Route("update")]
        [HttpPut]
        public async Task<IActionResult> Update(UpdateSupplierDto updateSupplierDto)
        {
            var result = await this.supplierService.Update(updateSupplierDto);
            return Ok(result);
        }
        [Route("delete/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this.supplierService.Delete(id);
            return Ok(result);
        }
    }
}
