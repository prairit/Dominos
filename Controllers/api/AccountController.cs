using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BAL;

namespace Doms.Controllers.api
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        AccountBAL accountBAL;
        public AccountController()
        {
            accountBAL = new AccountBAL();
        }
        [Route("IsValidUser")]
        [HttpPost]
        public IHttpActionResult IsValidUser(UserDto userDto)
        {
            if (accountBAL.ValidateUser(userDto))
                return Ok();
            return BadRequest();
        }

        [Route("RegisterUser")]
        [HttpPost]
        public IHttpActionResult RegisterUser(UserDto userDto)
        {
            accountBAL.RegisterUser(userDto);
            return Created(new Uri(Request.RequestUri +"/username=")+userDto.UserName,userDto);
        }
    }
}
