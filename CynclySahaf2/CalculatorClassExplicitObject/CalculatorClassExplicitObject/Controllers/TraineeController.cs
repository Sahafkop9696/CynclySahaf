using CalculatorClassExplicitObject.Models;
using CalculatorClassExplicitObject.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorClassExplicitObject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        List<string> trainees = new List<string>()
        {
            "Aswin", "Adijith", "Sahaf", "Rithin", "Aastha", "Nipun", "Atif", "Ananthu", "Meghna", "Averine"
        };


        [HttpGet]
        public List<string> GetTrainees()
        {
            return trainees;
        }

        [HttpGet("StartsWithA")]
        public List<string> GetTraineesStartsWithA()
        {
            var startsWithA = from p in trainees
                              where p.StartsWith("A")
                              select p;
            return startsWithA.ToList();
        }

        [HttpGet("TraineesLocation")]
        public List<Trainee> GetTraineesLocation()
        {
            TraineesRepository traineesRepository = new TraineesRepository();
            var trainees = traineesRepository.GetTrainees();
            return trainees;
        }

    }
}
