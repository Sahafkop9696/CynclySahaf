using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorControllerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return 8;
        }
        [HttpGet("Add")]
        public int GetAdd(int i, int j)
        {
            int result = i + j;
            return result;
        }
        [HttpGet("Substract")]
        public int GetSubstract(int i, int j)
        {
            int result = i - j;
            return result;
        }
        [HttpGet("Multiply")]
        public int GetMultiply (int i, int j)
        {
            int result = i * j;
            return result;
        }
    }
}
