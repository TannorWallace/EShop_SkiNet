using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);

        }


        public int StatusCode { get; set; }
        public string Message { get; set; }
        
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "You have made a bad request, Report to the Inquisition.",
                401 => "You Are not sanctioned (Authorized)",
                404 => "By the EMPEROR! The Resource was not found",
                500 => "Errors are the path of chaos",
                _ => null
            };
        }
    }
}