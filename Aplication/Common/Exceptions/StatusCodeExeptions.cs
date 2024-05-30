

using System.Net;

namespace Aplication.Common.Exceptions
{
    public class StatusCodeExeptions:Exception
    {
        public HttpStatusCode  StatusCode { get;  }
        public StatusCodeExeptions(HttpStatusCode code,string message):base(message) { StatusCode = code; } 
          
        

    }
}
