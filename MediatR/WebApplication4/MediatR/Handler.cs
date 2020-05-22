
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication4.MediatR
{
    public class Handler : IRequestHandler<Request, int>
    {
        public int Handle(Request req)
        {
            return req.Count;
           
        }
    }

    public class Handler2 : IRequestHandler<Request2, string>
    {
        public string Handle(Request2 req2)
        {
            return req2.Count;

        }
    }
}
