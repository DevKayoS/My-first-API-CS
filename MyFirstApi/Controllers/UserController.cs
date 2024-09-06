using System.Runtime.InteropServices.JavaScript;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

public class UserController : MyFirstApiBaseController
{
    // fazendo que o programa entenda que esse endpoint is a Get
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    { 
        var response = new User
        {
            Id = 1,
            Name = "Kayo",
            Age = 19
        };
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)] // tipo da resposta
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            name = request.Name
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }
    
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }
    
    [HttpGet]
    [Route("all")]
    [ProducesResponseType(typeof(List<User>),StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new User {Id = 1, Name = "Kayo", Age = 19},
            new User {Id = 2, Name = "Julia", Age = 19},
            new User {Id = 3, Name = "Andreia", Age = 42}
        };
        return Ok(response);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
            
        return NoContent();
    }
    
    
}