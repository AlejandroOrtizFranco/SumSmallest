using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SumSmallest.Models;
using SumSmallest.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SumSmallest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumController : ControllerBase
    {
        private readonly ISumService _service;

        public SumController(ISumService service)
        {
            _service = service;
        }
        // GET: api/<SumController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SumController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SumController>
        [HttpPost]
        public ActionResult<int> Post(SumDto sum)
        {
            return Ok(new {Result = _service.PostSum(sum.Numbers)});
        }

        // PUT api/<SumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
