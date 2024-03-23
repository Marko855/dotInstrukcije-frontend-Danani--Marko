using Microsoft.AspNetCore.Mvc;
using System;

namespace Instrukcije.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("register")]
        public IActionResult RegisterStudent(StudentRegistrationModel model)
        {
            var success = _studentService.RegisterStudent(model);
            return Ok(new { success = success });
        }

        [HttpPost("login")]
        public IActionResult LoginStudent(StudentLoginModel model)
        {
            var result = _studentService.LoginStudent(model.Email, model.Password);
            if (result.Success)
            {
                return Ok(new { success = true, student = result.Data, token = result.Token });
            }
            else
            {
                return Unauthorized(new { success = false, message = result.ErrorMessage });
            }
        }

        [HttpGet("{email}")]
        public IActionResult GetStudentByEmail(string email)
        {
            var result = _studentService.GetStudentByEmail(email);
            if (result.Success)
            {
                return Ok(new { success = true, student = result.Data });
            }
            else
            {
                return NotFound(new { success = false, message = result.ErrorMessage });
            }
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var result = _studentService.GetAllStudents();
            if (result.Success)
            {
                return Ok(new { success = true, students = result.Data });
            }
            else
            {
                return StatusCode(500, new { success = false, message = "Failed to retrieve students." });
            }
        }
    }
}
}
