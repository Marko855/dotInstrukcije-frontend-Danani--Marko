using Microsoft.AspNetCore.Mvc;
using System;

using Microsoft.AspNetCore.Mvc;
using System;

namespace Instrukcije.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        [Route("register/student")]
        public IActionResult RegisterStudent([FromBody] StudentRegistrationRequest request)
        {

            
            bool success = true; 
            string message = success ? "Student successfully registered." : "Registration failed.";

            return Ok(new { success, message });
        }
    }
}
