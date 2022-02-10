using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jlu_api_rest.Api.Models;
using jlu_api_rest.Global;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jlu_api_rest.Controllers
{
    [Route($"{Variable.BaseApi}/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        public HealthController()
        {
            
        }

        [HttpGet]
        public ActionResult<ResultHealthy> Get()
        {
            var result = new ResultHealthy
            {
                Description = "It's all good !"
            };
            return result;
        }
    }
}