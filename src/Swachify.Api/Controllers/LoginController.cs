using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace Swachify.Api;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    [HttpPost("login")]
    public ActionResult Login(string userName, string password)
    {
        if (userName == "admin" && password == "12345")
        {
            return Ok("Login Successful");
        }
        else
        {
            return Unauthorized("Invalid username or password");
        }
    }
}
