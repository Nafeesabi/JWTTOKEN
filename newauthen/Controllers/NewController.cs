using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;

namespace newauthen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated with JWT";
        }

        [HttpGet]
        [Route("Details")]

        public string Details()
        {
            return "Authenticated with JWT";
        }
       
    }
}
