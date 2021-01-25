using System;
using BookByIdApi.Businness;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookByIdApi.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/[Controller]/v{version:apiVersion}")]
    //[Authorize("Bearer")]
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;
        private IAddressBusinness AddressBusinness;

        public AddressController(ILogger<AddressController> logger, IAddressBusinness addressBusinness)
        {
            _logger = logger;
            AddressBusinness = addressBusinness;
        }
        [HttpPost]
        [ProducesResponseType((500))]
        public IActionResult Create([FromBody] AddressVO address)
        {
            if (address == null) return BadRequest("Requisição Inválida");
            return Ok(AddressBusinness.Create(address));
        }
        [HttpPut]
        public IActionResult Update([FromBody] AddressVO address)
        {
            if (address == null) return BadRequest("Requisição Invalida");
            return Ok(AddressBusinness.Update(address));
        }
        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(AddressBusinness.FindAll());
        }
    }
}
