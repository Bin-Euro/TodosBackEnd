using Microsoft.AspNetCore.Mvc;
using TodosBackEnd.Models;
using TodosBackEnd.Service.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodosBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _service;
        public TodosController(ITodosService service)
        {
            _service = service;
        }

        // GET: api/<TodosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetTodos());
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodosController>
        [HttpPost]
        public IActionResult Post(Todo todo)
        {
            return Ok(_service.AddTodo(todo));
        }

        // PUT api/<TodosController>/5
        [HttpPut()]
        public IActionResult Put(Todo todo)
        {
            return Ok(_service.UpdateTodo(todo));
        } 

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.DelTodo(id));
        }
    }
}
