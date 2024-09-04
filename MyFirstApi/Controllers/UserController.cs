using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

// como vai ficar o endpoint -> localhost:port/api/User
[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    // fazendo que o programa entenda que esse endpoint is a Get
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute]int id)
    {
        var response = new User
        {
            Id = 1,
            Name = "Kayo",
            Age = 19
        };
        return Ok(response);
    }
}