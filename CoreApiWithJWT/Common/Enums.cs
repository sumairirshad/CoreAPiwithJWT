using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiWithJWT.Common
{
    public class Enums
    {
        public enum ResponseType
        {
            [Description("Failure")]
            Failure = 0,
            [Description("Success")]
            Success = 1,
            [Description("Warning")]
            Warning = 2,
            [Description("Duplicate")]
            Duplicate = 3,
            [Description("Error")]
            Error = 4,
            
        }
    }
}
