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
    public class StateController : ControllerBase
    {
        private readonly IStateService stateService;
        public StateController(IStateService _stateService)
        {
            stateService = _stateService;
        }
        [Route("getAll")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await this.stateService.GetAll();
            return Ok(result);
        }
    }
}
