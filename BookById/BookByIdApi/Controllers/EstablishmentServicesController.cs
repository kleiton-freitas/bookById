using System;
using BookByIdApi.Businness;
using BookByIdApi.Data.ValueObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookByIdApi.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/[Controller]/v{version:apiVersion}")]
    //[Authorize("Bearer")]
    public class EstablishmentServicesController : Controller
    {
        private readonly ILogger<EstablishmentServicesController> _logger;
        private IEstablishmentServices EstablishmenServices;

        public EstablishmentServicesController(ILogger<EstablishmentServicesController> logger,
            IEstablishmentServices establishmenServices)
        {
            _logger = logger;
            EstablishmenServices = establishmenServices;
        }
        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(EstablishmenServices.FindAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] EstablishmentServicesVO service)
        {
            if (service == null) { return BadRequest("Requisicao invalida"); }
            return Ok(EstablishmenServices.Create(service));
        }
        [HttpPut]
        public IActionResult Update([FromBody] EstablishmentServicesVO service)
        {
            if (service == null) { return BadRequest("Requisicao invalida"); }
            return Ok(EstablishmenServices.Update(service));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            EstablishmenServices.Delete(id);
            return NoContent();
        }
    }
}
