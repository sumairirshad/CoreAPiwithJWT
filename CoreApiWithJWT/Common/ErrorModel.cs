using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiWithJWT.Common
{
    public class ErrorModel
    {
        public Exception Exception { get; set; }
        public string ErrorMessage { get; set; }
        public string Description { get; set; }
    }
}
