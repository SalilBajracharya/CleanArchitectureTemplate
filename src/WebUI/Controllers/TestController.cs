using ca_loyalty.WebUI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/whatever")]
    public class TestController : ApiControllerBase
    {
        [Authorize]
        [HttpGet("iamtesting")]
        public IActionResult Test(){
            return Ok();
        }
    }
}