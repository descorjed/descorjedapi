using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescorjedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAuthController : ControllerBase
    {

        [Authorize]
        [Route("login")]
        public async Task<ActionResult> GetLogin()
        {
            return Ok($"Your login {User.Identity.Name}");
        }
    }
}
