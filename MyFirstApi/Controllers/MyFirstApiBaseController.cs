using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyFirstApiBaseController : ControllerBase
    {
        public string Author { get; set; } = "Kayo Vinicius";
        
        [HttpGet("healthy")]
        public IActionResult Healthy()
        {
            return Ok("It's working!");
        }
        
        // tem que colocar protected para que o compilador nao entenda que e um novo endpoint
        protected string GetCustomKey() => Request.Headers["MyKey"].ToString();
            
    }
}
