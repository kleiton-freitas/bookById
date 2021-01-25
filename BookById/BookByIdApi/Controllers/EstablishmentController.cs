using BookByIdApi.Model;
using BookByIdApi.Businness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using BookByIdApi.Data.ValueObject;

namespace BookByIdApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    [Authorize("Bearer")]
    public class EstablishmentController : Controller
    {
        private readonly ILogger<EstablishmentController> _logger;
        private IEstablishment EstablishmenBusinness;

        public EstablishmentController(ILogger<EstablishmentController> logger, IEstablishment establishmentBusinness)
        {
            _logger = logger;
            EstablishmenBusinness = establishmentBusinness;
        }
        [HttpGet]
        //[ProducesResponseType((200), Type = typeof(List<EstablishmentVO>))]
        //[ProducesResponseType((400))]
        //[ProducesResponseType((404))]
        //[ProducesResponseType((401))]
        public IActionResult FindAll()
        {
            return Ok(EstablishmenBusinness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var establishment = EstablishmenBusinness.FindById(id);
            if (establishment == null) return NotFound();
            return Ok(establishment);
        }
        [HttpPost]
        public IActionResult Create([FromBody] EstablishmentVO establishment)
        {
            if (establishment == null) { return BadRequest("Requisicao invalida"); }
            return Ok(EstablishmenBusinness.Create(establishment));
        }
        [HttpPut]
        public IActionResult Update([FromBody] EstablishmentVO establishment)
        {
            if (establishment == null) { return BadRequest("Requisicao invalida"); }
            return Ok(EstablishmenBusinness.Update(establishment));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            EstablishmenBusinness.Delete(id);
            return NoContent();
        }
    }
}
