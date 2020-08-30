using System;
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
    public class categoriesController : Controller
    {
        private readonly hackertonDbContext _context;

        public categoriesController(hackertonDbContext context)
        {
            _context = context;
        }

        // GET: categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: categories/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Categories
                .FirstOrDefaultAsync(m => m.id == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // GET: categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,catname")] categories categories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categories);
        }

        // GET: categories/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Categories.FindAsync(id);
            if (categories == null)
            {
                return NotFound();
            }
            return View(categories);
        }

        // POST: categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,catname")] categories categories)
        {
            if (id != categories.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!categoriesExists(categories.id))
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
            return View(categories);
        }

        // GET: categories/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Categories
                .FirstOrDefaultAsync(m => m.id == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // POST: categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var categories = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(categories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool categoriesExists(string id)
        {
            return _context.Categories.Any(e => e.id == id);
        }
    }
}
