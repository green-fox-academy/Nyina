using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Controllers
{
    [Route("")]
    public class GuardianController : Controller
    {
        [HttpGet("groot")]
        public IActionResult Hello([FromQuery]string message)
        {
            if (message == null )
            {
                return BadRequest(new { error = "I am Groot!" });
            }
            return Json(new { received = message, translated = "I am Groot!" });
        }
    }
}
