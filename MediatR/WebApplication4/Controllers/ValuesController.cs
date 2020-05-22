using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.MediatR;
using WebApplication4.Service;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       // private IService _service;
        private readonly IMediator _mediator;
        public ValuesController(IMediator mediator)
        {
           this._mediator = mediator;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<dynamic> Get()
        {
            var a = 20;
            Console.WriteLine("test");
            return _mediator.Send(new Request()).Result;
           
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
