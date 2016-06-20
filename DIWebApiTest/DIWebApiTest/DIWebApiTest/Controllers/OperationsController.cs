using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DIWebApiTest.Models;

namespace DIWebApiTest.Controllers
{
    public class OperationsController : ApiController
    {
        private readonly OperationContext db;

        public OperationsController(OperationContext context)
        {
            db = context;
        }

        // GET: api/Operations
        public IQueryable<Operation> Get()
        {
            return db.Operations;
        }

        // GET: api/Operations/5
        [ResponseType(typeof(Operation))]
        public async Task<IHttpActionResult> Get(int id)
        {
            Operation operation = await db.Operations.FindAsync(id);
            if (operation == null)
            {
                return NotFound();
            }

            return Ok(operation);
        }

        // POST: api/Operations
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Operations/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Operations/5
        public void Delete(int id)
        {
        }
    }
}
