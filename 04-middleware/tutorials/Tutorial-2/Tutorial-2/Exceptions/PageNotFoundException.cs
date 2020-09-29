using System;
using System.Runtime.Serialization;

namespace Tutorial_2.Middleware
{
    [Serializable]
    internal class PageNotFoundException : ApplicationException
    {
        public override string Message => "page not found";
        public PageNotFoundException()
        {
        }

        public PageNotFoundException(string message) : base(message)
        {
        }

        public PageNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PageNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}