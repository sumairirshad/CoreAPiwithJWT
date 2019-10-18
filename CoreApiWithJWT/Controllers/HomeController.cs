using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApiWithJWT.Common;
using CoreApiWithJWT.Helper;
using CoreApiWithJWT.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiWithJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/Home
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody]LoginModel obj)
        {
            UserModel user = new UserModel();
            try
            {
               
                if (ModelState.IsValid)
                {
                    if (obj.Email == "demo" && obj.Password == "demo")
                    {
                        user.token = SecurityHelper.GenerateToken(user, "04180dac-78b8-43af-87b0-9d939de5f0d7", 40);
                    }
                }
                

            }
            catch (Exception ex)
            {
                return ApiResponse.Exception(ex, HttpContext.Request.Path);
            }

            return ApiResponse.Success(user, user.token, "");

        }

        // GET: api/Home/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
