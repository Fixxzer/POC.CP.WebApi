using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace POC.CP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET: api/HealthCheck
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(new {result = "OK", DateTime = DateTime.Now.ToString(CultureInfo.CurrentCulture), message="Roland was here"});
        }
    }
}
