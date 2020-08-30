using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group2.Models;
using Group2.context;
using Microsoft.AspNetCore.Authorization;

namespace Group2.Controllers
{
    [Authorize(Roles = "DOCTOR")]
    public class UserDetailsController : Controller
    {
        private readonly hackertonDbContext _context;

        public UserDetailsController(hackertonDbContext context)
        {
            _context = context;
        }

        // GET: UserDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.userDetails.ToListAsync());
        }

        // GET: UserDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetails = await _context.userDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDetails == null)
            {
                return NotFound();
            }

            return View(userDetails);
        }

        // GET: UserDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UswerId,date,DocId,Institution,IsDiagnosed,Problem,Comment")] UserDetails userDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userDetails);
        }

        // GET: UserDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetails = await _context.userDetails.FindAsync(id);
            if (userDetails == null)
            {
                return NotFound();
            }
            return View(userDetails);
        }

        // POST: UserDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UswerId,date,DocId,Institution,IsDiagnosed,Problem,Comment")] UserDetails userDetails)
        {
            if (id != userDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserDetailsExists(userDetails.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userDetails);
        }

        // GET: UserDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetails = await _context.userDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDetails == null)
            {
                return NotFound();
            }

            return View(userDetails);
        }

        // POST: UserDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userDetails = await _context.userDetails.FindAsync(id);
            _context.userDetails.Remove(userDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserDetailsExists(string id)
        {
            return _context.userDetails.Any(e => e.Id == id);
        }
    }
}
