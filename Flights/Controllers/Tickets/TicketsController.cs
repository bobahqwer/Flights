using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Flights.Models;
using Flights.Models.Tickets;

namespace Flights.Controllers.Tickets
{
    public class TicketsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tickets
        public async Task<ActionResult> Index()
        {
            return View(await db.TicketsViewModels.ToListAsync());
        }

        // GET: Tickets/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketsViewModels ticketsViewModels = await db.TicketsViewModels.FindAsync(id);
            if (ticketsViewModels == null)
            {
                return HttpNotFound();
            }
            return View(ticketsViewModels);
        }

        // GET: Tickets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TicketsId")] TicketsViewModels ticketsViewModels)
        {
            if (ModelState.IsValid)
            {
                db.TicketsViewModels.Add(ticketsViewModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ticketsViewModels);
        }

        // GET: Tickets/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketsViewModels ticketsViewModels = await db.TicketsViewModels.FindAsync(id);
            if (ticketsViewModels == null)
            {
                return HttpNotFound();
            }
            return View(ticketsViewModels);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TicketsId")] TicketsViewModels ticketsViewModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticketsViewModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ticketsViewModels);
        }

        // GET: Tickets/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketsViewModels ticketsViewModels = await db.TicketsViewModels.FindAsync(id);
            if (ticketsViewModels == null)
            {
                return HttpNotFound();
            }
            return View(ticketsViewModels);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TicketsViewModels ticketsViewModels = await db.TicketsViewModels.FindAsync(id);
            db.TicketsViewModels.Remove(ticketsViewModels);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
