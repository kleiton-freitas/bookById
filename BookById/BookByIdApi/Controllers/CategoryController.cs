using BookByIdApi.Businness;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookByIdApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    //[Authorize("Bearer")]
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private ICategory Category;

        public CategoryController(ILogger<CategoryController> logger, ICategory category)
        {
            _logger = logger;
            Category = category;
        }
        //LIST ALL
        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(Category.FindAll());
        }
        //FIND BY ID
        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var category = Category.FindById(id);
            if (category == null) return NotFound();
            return Ok(category);
        }
        //FIND BY FILTER
        [HttpGet("filtro/{name}")]
        public IActionResult FindByFilter(string name)
        {
            var category = Category.FindByFilter(name);
            if (category == null) return NotFound();
            return Ok(category);
        }
        //CREATE
        [HttpPost]
        public IActionResult Create([FromBody] CategoryVO category)
        {
            if (category == null) return BadRequest("Requisição Invalida");

            return Ok(Category.Create(category));
        }

        //UPDATE
        [HttpPut]
        public IActionResult Update([FromBody] CategoryVO category)
        {
            if (category == null) return BadRequest("Requisição Invalida");
            return Ok(Category.Update(category));
        }

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Category.Delete(id);
            string result = "Excludo com sucesso!";
            return Ok(result);
        }

    }
}
