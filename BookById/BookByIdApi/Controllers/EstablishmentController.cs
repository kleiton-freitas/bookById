using BookByIdApi.Model;
using BookByIdApi.Businness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BookByIdApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
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
