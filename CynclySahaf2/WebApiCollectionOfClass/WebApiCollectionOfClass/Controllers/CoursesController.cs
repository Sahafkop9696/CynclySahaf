
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCollectionOfClass.CourseRepository;

namespace WebApiCollectionOfClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        CoursesRepository _context = new CoursesRepository();

        [HttpGet]
        public List<string> Get()
        {
            var courses = _context.GetCourses().ToList();
            return courses;
        }
    }
}