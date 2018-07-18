using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public sealed class Response<ResponseObj>:Response
    {
        public ResponseObj Obj { get; set; }
    }
}