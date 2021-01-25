using BookByIdApi.Businness;
using BookByIdApi.Data.ValueObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BookByIdApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    //[Authorize("Bearer")]
    public class UserScheduleController : Controller
    {
        private readonly ILogger<UserScheduleController> _logger;
        private IUserSchedule Schedules;

        public UserScheduleController(ILogger<UserScheduleController> logger, IUserSchedule schedules)
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
            var entity = Schedules.FindById(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
        [HttpPost]
        public IActionResult Create([FromBody] UserSchedulesVO schedules)
        {
            if (schedules == null) { return BadRequest("Requisicao invalida"); }
            return Ok(Schedules.Create(schedules));
        }
        [HttpPut]
        public IActionResult Update([FromBody] UserSchedulesVO schedules)
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
