using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiWithJWT.Model
{
    public class LoginModel
    {
        public string Email { get; set; }
        //  [RequiredIfFalse("AppLogin")]
        public string Password { get; set; }
    }
}
