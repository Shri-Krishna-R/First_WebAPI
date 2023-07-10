using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [Route("/Welcome")]
        [HttpGet]
        public IActionResult Greet()
        {
            return Ok("Testing the Greet Option");
        }
        [Route("/Welcome/{name}")]
        [HttpGet]
        public IActionResult Greet(string name)
        {
            string message = "Hello " + name + ". Welcome to test API";
            return Ok(message);
        }
    }
}
