using Microsoft.AspNetCore.Mvc;
using B01_WebAPI8Hello.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace B01_WebAPI8Hello.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        TrainingManagementCynclyTrainingContext trainingManagementCynclyTrainingContext = new TrainingManagementCynclyTrainingContext();

        // GET: api/<CollegeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CollegeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollegeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CollegeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollegeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
