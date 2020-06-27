using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JwtTokenValidationExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PageController : ControllerBase
    {
        public PageController(ILogger<PageController> logger)
        {
            myLogger = logger;
        }

        [Authorize]
        [HttpGet]
        public string Get()
        {
            myLogger.LogInformation("The Get method is called in PageController.");
            return "It's working! THe authorization was successful.";
        }

        private readonly ILogger<PageController> myLogger;
    }
}
