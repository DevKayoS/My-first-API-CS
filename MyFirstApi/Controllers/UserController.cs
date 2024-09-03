using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

// como vai ficar o endpoint -> localhost:port/api/User
[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    // fazendo que o programa entenda que esse endpoint is a Get
    [HttpGet]
    public IActionResult Get()
    {
        var response = new Response
        {
            Name = "Kayo",
            Age = 19
        };
        return Ok(response);
    }
}