using Microsoft.AspNetCore.Mvc;

namespace DarkFront_Server.Controllers
{
    [ApiController]
    [Route("player")]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Example Response";
        }
    }
}
