using System;
using System.Collections.Generic;
using BookByIdApi.Businness;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookByIdApi.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/[Controller]/v{version:apiVersion}")]
    public class EstablishmentBusinnessController : Controller
    {
        private readonly ILogger<EstablishmentBusinnessController> _logger;
        private readonly IEstablishmentBusinness EstablishmentBusinness;

        public EstablishmentBusinnessController(ILogger<EstablishmentBusinnessController> logger,
            IEstablishmentBusinness establishmentBusinness)
        {
            _logger = logger;
            EstablishmentBusinness = establishmentBusinness;
        }

        [HttpPost]
        public IActionResult Create([FromBody] EstablishmentBusinnessVO establishmentBusinnessVO)
        {
            if (establishmentBusinnessVO == null) return BadRequest("Requisição Inválida");
            return Ok(EstablishmentBusinness.Create(establishmentBusinnessVO));
        }
        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(EstablishmentBusinness.FindAll());
        }
        [HttpPut]
        public IActionResult Update([FromBody] EstablishmentBusinnessVO establishmentBusinnessVO)
        {
            if (establishmentBusinnessVO == null) return BadRequest("Requisição Inválida");
            return Ok(EstablishmentBusinness.Update(establishmentBusinnessVO));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            EstablishmentBusinness.Delete(id);
            string result = "Estabelecimento excluído com sucesso!";
            return Ok(result);
        }
    }
}
