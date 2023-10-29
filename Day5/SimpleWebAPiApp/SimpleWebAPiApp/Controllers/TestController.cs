using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public string Get() {
            return "Get called";
        }

        [HttpPost]
        public string Post()
        {
            return "post called";
        }

        [HttpPut]
        public string Put() {
            return "put post";
        }
    }
}
