using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yondu.Controllers
{
    [Route("")]
    public class YonduController : Controller
    {
        [HttpGet("yondu")]
        public IActionResult YonduSpeed([FromQuery]double? distance, [FromQuery] double? time)
        {
            if (distance == null || time == null)
            {
                return BadRequest(new { error = "Please give a not null positive number!" });
            }
            return Json(new { distance = distance, time = time, speed = distance / time });
        }
    }
}
