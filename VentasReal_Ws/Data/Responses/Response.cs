using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasReal_Ws.Data.Responses
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public Response()
        {
            this.IsSuccess = false;
        }
    }
}
