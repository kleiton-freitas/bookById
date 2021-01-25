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
    //[Authorize("Bearer")]
    public class SchedulesController : Controller
    {
        private readonly ILogger<SchedulesController> _logger;
        private ISchedules Schedules;

        public SchedulesController(ILogger<SchedulesController> logger, ISchedules schedules)
        {
            _logger = logger;
            Schedules = schedules;
        }
        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(Schedules.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var establishment = Schedules.FindById(id);
            if (establishment == null) return NotFound();
            return Ok(establishment);
        }
        [HttpPost]
        public IActionResult Create([FromBody] SchedulesVO schedules)
        {
            if (schedules == null) { return BadRequest("Requisicao invalida"); }
            return Ok(Schedules.Create(schedules));
        }
        [HttpPut]
        public IActionResult Update([FromBody] SchedulesVO schedules)
        {
            if (schedules == null) { return BadRequest("Requisicao invalida"); }
            return Ok(Schedules.Update(schedules));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Schedules.Delete(id);
            return NoContent();
        }
    }
}
