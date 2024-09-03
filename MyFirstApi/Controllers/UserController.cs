using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;


// como vai ficar o endpoint -> localhost:port/api/User
[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    
}