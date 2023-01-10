using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Enums
{
    public class Enumss
    {
        public enum StatusCode
        {
            Ok = 200,
            Created = 201,
            Accepted = 202,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404,
            InternalServerError = 500
        }
    }
}
