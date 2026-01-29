
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

        //[HttpGet]
        //public List<string> GetCoursesSourted()
        //{
        //    var coursesSorted = (from p in _context.GetCourses()
        //                         orderby p descending
        //                         select p).ToList();
        //    return coursesSorted;

        //}
        [HttpGet]
        public List<string> GetCoursesStartsWithE()
        {
            var coursesSorted = (from p in _context.GetCourses()
                                 where p.StartsWith("E")
                                 select p).ToList();
            return coursesSorted;

        }

    }
}