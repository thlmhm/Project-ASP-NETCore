using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Wrappers
{
    public class Response<T>
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }

        public Response()
        {

        }

        public Response(bool IsSuccess, string message)
        {
            IsSucceeded = IsSuccess;
            Message = message;
            Errors = new List<string>();
        }

        public Response(bool IsSuccess, string message, List<string> lstErrors)
        {
            IsSucceeded = IsSuccess;
            Message = message;
            Errors = lstErrors;
        }
    }
}
