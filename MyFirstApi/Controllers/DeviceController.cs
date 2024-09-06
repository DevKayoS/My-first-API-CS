using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers
{
    public class DeviceController : MyFirstApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            var laptop = new Laptop();

            var brand = laptop.GetBrand();
            
            return Ok(laptop.Hello()); // retornar macbook
        }
    }
}
