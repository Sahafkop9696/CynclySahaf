using CalculatorClassExplicitObject.Classes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorClassExplicitObject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        [HttpGet]
        public int Add(int i, int j)
        {
            int sum = CalculatorClass.Add(i, j);
            return sum;
        }
        [HttpGet("Substract")]
        public int GetSubstract(int i, int j)
        {
            CalculatorClass calculator = new CalculatorClass();
            int substract = calculator.Substract(i, j);
            return substract;
        }
    }
}
