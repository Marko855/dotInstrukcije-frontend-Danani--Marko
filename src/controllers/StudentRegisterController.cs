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

    }
}
