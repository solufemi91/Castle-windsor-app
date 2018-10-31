using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CWapp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private ICompositionRoot _compositionRoot;

        public ValuesController(ICompositionRoot compositionRoot)
        {
            _compositionRoot = compositionRoot;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            _compositionRoot.LogMessage("Hello");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
