using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_api.ViewModel.Responses
{
    public class BaseResponse
    {
        public string Message { get; private set; }
        public dynamic Data { get; private set; }

        public BaseResponse(string message, dynamic data)
        {
            Message = message;
            Data = data;
        }
    }
}