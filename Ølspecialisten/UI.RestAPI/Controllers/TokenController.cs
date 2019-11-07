using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ølspecialisten.Core.ApplicationServices;
using Ølspecialisten.Core.Entity;

namespace UI.RestAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        private IUserService _userService;

        public TokenController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<String> Get()
        {
            String a = "test";
            return a;
        }

        [HttpPost]
        public ActionResult Login([FromBody]LoginForm loginForm)
        {
            var username = loginForm.UserName;
            var token = _userService.genereateToken(loginForm);
            if (username != null)
            {
                return Ok(new
                {
                    username,
                    token
                });
            }
            else
            {
                return Unauthorized();
            }
           


        }

    }
}
