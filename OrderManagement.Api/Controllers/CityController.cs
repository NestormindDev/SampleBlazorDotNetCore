using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Api.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService cityService;
        public CityController(ICityService _cityService)
        {
            cityService = _cityService;
        }
        [Route("get/{stateId}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int stateId)
        {
            var result = await this.cityService.GetById(stateId);
            return Ok(result);
        }
    }
}
