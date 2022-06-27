using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_007.Controllers
{
    /*ASP_007*/
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello My Api";
        }
    }
}
