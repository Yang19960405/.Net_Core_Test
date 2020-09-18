using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreTest.Controllers
{
    [ApiController]
    public class JWTController : ControllerBase
    {
        [HttpGet]
        [Route("api/getValue1")]
        public ActionResult<IEnumerable<string>> GetValue1()
        {
            return new string[] { "a", "b" };
        }

        [HttpGet]
        [Route("api/getValue2")]
        [Authorize]
        public ActionResult<IEnumerable<string>> GetValue2()
        {
            return new string[] { "aa", "bb" };
        }
    }
}
