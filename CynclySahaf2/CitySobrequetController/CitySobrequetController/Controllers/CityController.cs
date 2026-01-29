using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitySobrequetController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        // GET: api/<CityController>
        [HttpGet]
        public string Get(string city)
        {
            string sobrequet = "";
            if (city == "Kochi")
            {
                sobrequet = "Queen Of Malabar Sea";
            }
            else if (city == "Kozhikode")
            {
                sobrequet = "Food Capital of Kerala";
            }

            return sobrequet;
        }
    }
}
