using System;
using System.Net.Http;
using System.Runtime.Serialization;

namespace DemoMock.Controllers
{
    [Serializable]
    internal class HttpResponseException : Exception
    {
        private HttpResponseMessage message;

        public HttpResponseException()
        {
        }

        public HttpResponseException(HttpResponseMessage message)
        {
            this.message = message;
        }

        public HttpResponseException(string message) : base(message)
        {
        }

        public HttpResponseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HttpResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}