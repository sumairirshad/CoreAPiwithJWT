using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreApiWithJWT.Common
{
    public class ApiResponse
    {
        private static List<ErrorModel> _errors;
        public static IActionResult Success(object data, string token = null, string message = null)
        {
            return new OkObjectResult(new ResponseModel()
            {
                HasError = false,
                Data = data,
                type = Enums.ResponseType.Success,
                token = token,
                message = message,
            });
        }


        public static IActionResult Exception(Exception exception, string path, string message = null)
        {
            return new BadRequestObjectResult(new ResponseModel() { HasError = true, type = Enums.ResponseType.Error, Error = _errors });
        }

    }
}
