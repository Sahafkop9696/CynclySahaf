using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRevision.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello SAHAF";
        }
        [HttpGet("HelloName")]
        public string GetName(string name)
        {
            return $"Hello {name}";
        }
        [HttpGet("HelloNameLoc")]
        public string GetNameLoc(string name, string location)
        {
            return $"Hello {name}, You are from {location}";
        }
    }
}
