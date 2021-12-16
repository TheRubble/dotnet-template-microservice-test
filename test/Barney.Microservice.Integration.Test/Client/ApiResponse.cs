using System.Net;

namespace Barney.Microservice.Integration.Test.Client
{
    public class ApiResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Result { get; set; }
        public string ResultAsString { get; set; }
    }
}