using Api.model;
using Api.Serivce;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissileControler : ControllerBase
    {
        public MissileControler()
        {
        }
        TodoService service = new TodoService();
        [HttpGet]
        public IEnumerable<Missile> Get()
        {
            return service.GetData();
        }
        [HttpGet]
        [Route("GetByPlace")]
        public IEnumerable<Missile> Getbyplace(string place)
        {
            return service.GetData(place);
        }
        [HttpPost]
        public bool post(Missile missile)
        {
            return service.add(missile);
        }
        [HttpGet]
        [Route("placesmissile")]
        public IEnumerable<string> GetPlace()
        {
            return (IEnumerable<string>)service.GetData().Where(t => t.Place != null).ToList();

        }
    }
}

