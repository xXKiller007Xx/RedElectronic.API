using Microsoft.AspNetCore.Mvc;
using RedElectronic.External.Todo.Service;

namespace RedElectionic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet("get-all-todo")]
        public async Task<IActionResult> GetAllTodo()
        {
            try
            {
                var res = await _todoService.GetAllTodos();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
