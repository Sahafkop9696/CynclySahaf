using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficialTasks : ControllerBase
    {
        // GET: api/<OfficialTasks>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new 
        }

        // GET api/<OfficialTasks>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OfficialTasks>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OfficialTasks>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OfficialTasks>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
