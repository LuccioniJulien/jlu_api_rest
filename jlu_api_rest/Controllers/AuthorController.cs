using Microsoft.AspNetCore.Mvc;

namespace jlu_api_rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeController : ControllerBase
    {
        // GET
        [HttpGet]
        public IActionResult>< Get()
        {
            return null;
        }
        
        
    }
}