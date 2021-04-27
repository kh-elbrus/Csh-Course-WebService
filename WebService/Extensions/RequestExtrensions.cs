using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebService.Extensions
{
    public static class RequestExtrensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            return request

            .Headers["x-requested-with"]
            .Equals("XMLHttpRequest");
        }
    }
}
