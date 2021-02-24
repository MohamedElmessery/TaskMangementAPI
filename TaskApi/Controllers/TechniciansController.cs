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
    public class TechniciansController : ApiController
    {
        private Acropol_MaintenanceDB3Entities db = new Acropol_MaintenanceDB3Entities();

        // GET: Technicians
        public IQueryable<Technician> GetTechnicians()
        {
            return db.Technicians;
        }

        // GET: Technicians/5
        [ResponseType(typeof(Technician))]
        public async Task<IHttpActionResult> GetTechnician(int id)
        {
            Technician technician = await db.Technicians.FindAsync(id);
            if (technician == null)
            {
                return NotFound();
            }

            return Ok(technician);
        }

        // PUT: Technicians/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTechnician(int id, Technician technician)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != technician.TechId)
            {
                return BadRequest();
            }

            db.Entry(technician).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechnicianExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: Technicians
        [ResponseType(typeof(Technician))]
        public async Task<IHttpActionResult> PostTechnician(Technician technician)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Technicians.Add(technician);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = technician.TechId }, technician);
        }

        // DELETE: Technicians/5
        [ResponseType(typeof(Technician))]
        public async Task<IHttpActionResult> DeleteTechnician(int id)
        {
            Technician technician = await db.Technicians.FindAsync(id);
            if (technician == null)
            {
                return NotFound();
            }

            db.Technicians.Remove(technician);
            await db.SaveChangesAsync();

            return Ok(technician);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TechnicianExists(int id)
        {
            return db.Technicians.Count(e => e.TechId == id) > 0;
        }
    }
}