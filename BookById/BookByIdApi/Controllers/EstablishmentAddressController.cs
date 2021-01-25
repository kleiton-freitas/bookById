using System;
using System.Collections.Generic;
using BookByIdApi.Businness;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BookByIdApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    //[Authorize("Bearer")]
    public class EstablishmentAddressController : Controller
    {
        private readonly ILogger<EstablishmentAddress> _logger;
        private readonly IEstablishmentAddress EstablishmentAddress;

        public EstablishmentAddressController(ILogger<EstablishmentAddress> logger, IEstablishmentAddress establishmentAddress)
        {
            _logger = logger;
            EstablishmentAddress = establishmentAddress;
        }
        [HttpPost]
        public IActionResult Create([FromBody] EstablishmentAddressVO establishmentAddressVO)
        {
            if (establishmentAddressVO == null) return BadRequest("Requisição Inválida");
            return Ok(EstablishmentAddress.Create(establishmentAddressVO));
        }
        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(EstablishmentAddress.FindAll());
        }
        [HttpPut]
        public IActionResult Update([FromBody] EstablishmentAddressVO establishmentAddressVO)
        {
            if (establishmentAddressVO == null) return BadRequest("Requisição Inválida");
            return Ok(EstablishmentAddress.Update(establishmentAddressVO));
        }
        
    }
}
