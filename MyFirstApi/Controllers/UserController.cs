using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

// como vai ficar o endpoint -> localhost:port/api/User
[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    // fazendo que o programa entenda que esse endpoint is a Get
    [HttpGet]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    public IActionResult Get(string name, int age)
    {
        var response = new Response
        {
            Name = name,
            Age = age
        };
        return Ok(response);
    }
}