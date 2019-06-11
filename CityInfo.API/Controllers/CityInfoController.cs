using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityInfoController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetAction()
        {
            var result = new { AppName = "City Info API", Version = "1.0", Status = "Active" };
            return Ok(result);
        }
        [HttpGet("Welcome")/*, Name = "WelcomeFunc"*/]
        public async Task<IActionResult> WelcomeMsg()
        {
            string msg = "City Info API";
            var i = await msg.ToAsyncEnumerable().Count();

            return Ok(msg);
        }
    }
}