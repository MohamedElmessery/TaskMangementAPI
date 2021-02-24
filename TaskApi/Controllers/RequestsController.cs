using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TaskApi.Models;

namespace TaskApi.Controllers
{
    public class RequestsController : ApiController
    {
        private Acropol_MaintenanceDB3Entities db = new Acropol_MaintenanceDB3Entities();

        // GET: Requests
        public IQueryable<TechRequest> GetTechRequests()
        {
            return db.TechRequests;
        }

        // GET: Requests/5
        [ResponseType(typeof(TechRequest))]
        public async Task<IHttpActionResult> GetTechRequest(int id)
        {
            TechRequest techRequest = await db.TechRequests.FindAsync(id);
            if (techRequest == null)
            {
                return NotFound();
            }

            return Ok(techRequest);
        }

        

        // POST: Requests
        [ResponseType(typeof(TechRequest))]
        public async Task<IHttpActionResult> PostTechRequest(TechRequest techRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TechRequests.Add(techRequest);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TechRequestExists(techRequest.RequestId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = techRequest.RequestId }, techRequest);
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TechRequestExists(int id)
        {
            return db.TechRequests.Count(e => e.RequestId == id) > 0;
        }
    }
}