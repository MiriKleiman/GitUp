using Api.model;
using Api.Serivce;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
      
        public TodoController()
        {
           
        }
        TodoService service = new TodoService();
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
           return  service. GetData();
        }
        [HttpGet]
        [Route("GetById")]
        public IEnumerable<Todo> Getbyid(int id)
        {
            return service.GetData(id);
        }
        [HttpPost]
        public bool post(Todo todo )
        {   
            return service.add (todo );
        }
    }
}
