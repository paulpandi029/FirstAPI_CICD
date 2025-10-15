using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myFirstApi_CICD.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok(new { Message = "Hello from GitHub Actions 🚀" });
        }
    }
}
