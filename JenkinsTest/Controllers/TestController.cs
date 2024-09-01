using Microsoft.AspNetCore.Mvc;

namespace JenkinsTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public IActionResult Get()
        {
            return Ok("V1");
        }
    }
}
