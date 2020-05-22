using MediatR;

namespace WebApplication4.MediatR
{
    public class Request : IRequest<int> 
    {
        public int Count { get { return 5; } }
    }

    public class Request2 : IRequest<string>
    {
        public string Count { get { return "Five"; } }
    }
}