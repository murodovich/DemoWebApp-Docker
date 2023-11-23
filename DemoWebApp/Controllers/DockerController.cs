using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DockerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Qaytar(string Name,int Age)
        {
            return Ok($"ism : {Name}  yosh: {Age}");
        }
    }
}
