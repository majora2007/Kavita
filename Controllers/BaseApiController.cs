using Microsoft.AspNetCore.Mvc;

namespace Kavita.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        public BaseApiController()
        {
        }
    }
}