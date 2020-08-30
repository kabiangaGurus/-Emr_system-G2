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
    public class Doc_ResController : Controller
    {
        private readonly hackertonDbContext _context;

        public Doc_ResController(hackertonDbContext context)
        {
            _context = context;
        }

        // GET: Doc_Res
        public async Task<IActionResult> Index(string searching)
        {
            return View(await _context.doc_Res.Where(x => x.serviceNo.Contains(searching) || searching == null).ToListAsync());

           // return View(await _context.doc_Res.ToListAsync());
        }

        // GET: Doc_Res/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doc_Res = await _context.doc_Res
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doc_Res == null)
            {
                return NotFound();
            }

            return View(doc_Res);
        }

        // GET: Doc_Res/Create
        public IActionResult Create()
        {
            ViewBag.entity_type = new SelectList(_context.roles, "Role", "Role");
            return View();
        }

        // POST: Doc_Res/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fULL_NAME,uSERNAME,ROLE,PHONE,serviceNo,PASSWORD")] Doc_Res doc_Res)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doc_Res);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(doc_Res);
        }

        // GET: Doc_Res/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doc_Res = await _context.doc_Res.FindAsync(id);
            if (doc_Res == null)
            {
                return NotFound();
            }
            return View(doc_Res);
        }

        // POST: Doc_Res/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,fULL_NAME,uSERNAME,ROLE,PHONE,serviceNo,PASSWORD")] Doc_Res doc_Res)
        {
            if (id != doc_Res.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doc_Res);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doc_ResExists(doc_Res.Id))
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
            return View(doc_Res);
        }

        // GET: Doc_Res/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doc_Res = await _context.doc_Res
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doc_Res == null)
            {
                return NotFound();
            }

            return View(doc_Res);
        }

        // POST: Doc_Res/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var doc_Res = await _context.doc_Res.FindAsync(id);
            _context.doc_Res.Remove(doc_Res);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Doc_ResExists(string id)
        {
            return _context.doc_Res.Any(e => e.Id == id);
        }
    }
}
