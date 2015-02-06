using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
//using VNext.Data;
using VNext.AspNet.Library;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace VNext.Api.Controllers.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        //[HttpGet]
        //[Route("message")]
        //public string GetMessageFromLibrary()
        //{
        //    return Greetings.Message();
        //}
        [HttpGet]
        [Route("hola2")]
        public string GetMessageFromAspLibrary()
        {
            return Saludos.Message();
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
