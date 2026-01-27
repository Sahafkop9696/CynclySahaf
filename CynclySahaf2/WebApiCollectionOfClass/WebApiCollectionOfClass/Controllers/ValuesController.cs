using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCollectionOfClass.Models;

namespace B011_WebApiCollectionOfClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {


        [HttpGet]
        public List<Trainee> Get()
        {
            List<Trainee> trainees = new List<Trainee>()
            {
                new Trainee
                {
                    TraineeId = 1,
                    TraineeName = "Sahaf",
                    Location = "Calicut"
                },
                new Trainee
                {
                    TraineeId = 2,
                    TraineeName = "Aastha",
                    Location = "Kannur"
                }
            };
            return trainees;
        }
    }
}