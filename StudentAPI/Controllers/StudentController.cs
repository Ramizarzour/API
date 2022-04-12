using Microsoft.AspNetCore.Mvc;
using Models; 
using Services;
namespace StudentAPI.Controllers;

//[ApiController]
//[Route("[Controller]")]


public class Controllers : Controller
{

    private readonly IStudentServices _Services;
    private readonly object Name;
    private readonly ILogger<Controllers> _logger;

    public Controllers(ILogger<Controllers> logger, IStudentServices Services)
    {
        _Services = Services;

    }
    [HttpGet("GetStudents")]
    public async Task<IActionResult> GetStudents()
    {
        var students = await _Services.GetStudents();
        return Ok(students);
    }

    [HttpPost("AddStudents")]
    public async Task<IActionResult> AddStudents(string StudentName)
    {
        var students = await _Services.AddStudent(StudentName);
        return Ok(students);
    }
    [HttpGet("GetStudentById")]
    public async Task<IActionResult> GetStudentById(int StudentId)
    {
        var students = await _Services.GetStudentByID(StudentId);
        return Ok(students);
    }
    [HttpGet("GetStudentByName")]
    public async Task<IActionResult> GetStudentByName(string StudentName)
    {
        var students = await _Services.GetStudentByName(StudentName);
        return Ok(students);
    }
    [HttpGet("GetCourseByStudent")]
    public async Task<IActionResult> GetCourseByStudent(string StudentName)
    {
        var Courses= await _Services.GetCourseByStudent(StudentName);
        return Ok(Courses);
    }
    [HttpPut("UpdateStudentName")]
    public async Task<IActionResult> update(string Name, int ID)
    {
        var result = await _Services.UpdateStudentName(Name, ID);
        return Ok(result);
    }
   


}

