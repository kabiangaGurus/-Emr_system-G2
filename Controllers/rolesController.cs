﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group2.Models;
using Group2.context;

namespace Group2.Controllers
{
    public class rolesController : Controller
    {
        private readonly hackertonDbContext _context;

        public rolesController(hackertonDbContext context)
        {
            _context = context;
        }

        // GET: roles
        public async Task<IActionResult> Index()
        {
            return View(await _context.roles.ToListAsync());
        }

        // GET: roles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _context.roles
                .FirstOrDefaultAsync(m => m.id == id);
            if (roles == null)
            {
                return NotFound();
            }

            return View(roles);
        }

        // GET: roles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Role")] roles roles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        // GET: roles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _context.roles.FindAsync(id);
            if (roles == null)
            {
                return NotFound();
            }
            return View(roles);
        }

        // POST: roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,Role")] roles roles)
        {
            if (id != roles.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!rolesExists(roles.id))
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
            return View(roles);
        }

        // GET: roles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _context.roles
                .FirstOrDefaultAsync(m => m.id == id);
            if (roles == null)
            {
                return NotFound();
            }

            return View(roles);
        }

        // POST: roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var roles = await _context.roles.FindAsync(id);
            _context.roles.Remove(roles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool rolesExists(string id)
        {
            return _context.roles.Any(e => e.id == id);
        }
    }
}
