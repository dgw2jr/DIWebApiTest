using System.Collections.Generic;
using System.Web.Http;
using DIWebApiTest.Models;
using System.Web;

namespace DIWebApiTest.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        private IGreeter _greeter;
        private IIdProvider _idProvider;

        public ValuesController(IGreeter greeter, IIdProvider idProvider)
        {
            _greeter = greeter;
            _idProvider = idProvider;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] {
                _greeter.Greet(),
                _idProvider.Next().ToString()
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
