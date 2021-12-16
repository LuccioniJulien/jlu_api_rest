using jlu_api_rest.Global;
using Microsoft.AspNetCore.Mvc;

namespace jlu_api_rest.Controllers
{
    [ApiController]
    [Route($"{Variable.BaseApi}/[controller]")]
    public class ProjectController : ControllerBase
    {
        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return null;
        }
    }
}