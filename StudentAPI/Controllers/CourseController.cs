using Microsoft.AspNetCore.Mvc;
using Services;

namespace StudentAPI.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseServices _Services;
        private readonly object Name;
        private readonly ILogger<Controllers> _logger;
        public CourseController(ILogger<Controllers> logger, ICourseServices Services)
        {
            _Services = Services;

        }
        [HttpGet("GetCourses")]
        public async Task<IActionResult> GetCourses()
        {
            var students = await _Services.GetCourses();
            return Ok(students);
        }
        [HttpPost("AddCourses")]
        public async Task<IActionResult> AddCourse(string CourseName)
        {
            var students = await _Services.AddCourse(CourseName);
            return Ok(students);
        }
        [HttpGet("GetCourseById")]
        public async Task<IActionResult> GetCourseByID(int CourseId)
        {
            var students = await _Services.GetCourseByID(CourseId);
            return Ok(students);
        }
        [HttpGet("GetCourseByName")]
        public async Task<IActionResult> GetCourseByName(string CourseName)
        {
            var students = await _Services.GetCourseByName(CourseName);
            return Ok(students);

        }
        [HttpGet("GetStudentByCourse")]
        public async Task<IActionResult> GetStudentByCourse(string CourseName)
        {
            var students = await _Services.GetStudentByCourse(CourseName);
            return Ok(students);
        }
        [HttpPut("UpdateCourseName")]
        public async Task<IActionResult> update(string Name, int ID)
        {
            var result = await _Services.UpdateCourseName(Name, ID);
            return Ok(result);
        }
    }
}