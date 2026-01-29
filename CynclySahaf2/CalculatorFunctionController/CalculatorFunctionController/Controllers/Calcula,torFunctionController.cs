using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorFunctionController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public int GetAdd(int i, int j)
        {
            int sum = Add(i,j);
            return sum;
        }
        [NonAction]
        public int Add(int i, int j)
        {
            int result = i + j;
            return result;
        }

    }
}
