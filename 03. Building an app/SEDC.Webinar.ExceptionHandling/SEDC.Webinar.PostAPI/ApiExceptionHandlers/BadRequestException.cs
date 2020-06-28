using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.PostAPI.ApiExceptionHandlers
{
    public class BadRequestException : Exception
    {
        public int StatusCode { get; set; }

        public BadRequestException(string message, Exception innerException, int statusCode)
            :base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
