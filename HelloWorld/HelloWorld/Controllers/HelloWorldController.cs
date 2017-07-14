
using Microsoft.AspNetCore.Mvc;

namespace HelloWorl.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        // GET api/helloWorld
        [HttpGet]
        public string Get()
        {
            var greeting = "Hello World";
            return greeting;
        }

    }
}
