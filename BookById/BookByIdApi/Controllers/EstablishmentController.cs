using BookByIdApi.Model;
using BookByIdApi.Businness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace BookByIdApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    [Authorize("Bearer")]
    public class EstablishmentController : Controller
    {
        private readonly ILogger<EstablishmentController> _logger;
        private IEstablishmentBusinness EstablishmentService;

        public EstablishmentController(ILogger<EstablishmentController> logger, IEstablishmentBusinness establishmentService)
        {
            _logger = logger;
            EstablishmentService = establishmentService;
        }
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<Establishment>))]
        [ProducesResponseType((400))]
        [ProducesResponseType((404))]
        [ProducesResponseType((401))]
        public IActionResult FindAll()
        {
            return Ok(EstablishmentService.FindAll());
        }
        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var establishment = EstablishmentService.FindById(id);
            if (establishment == null) return NotFound();
            return Ok(establishment);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Establishment establishment)
        {
            if (establishment == null) { return BadRequest("Requisicao invalida"); }
            return Ok(EstablishmentService.Create(establishment));
        }
        [HttpPut]
        public IActionResult Update([FromBody] Establishment establishment)
        {
            if (establishment == null) { return BadRequest("Requisicao invalida"); }
            return Ok(EstablishmentService.Update(establishment));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            EstablishmentService.Delete(id);
            return NoContent();
        }
    }
}
