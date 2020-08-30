using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group2.Models;
using Group2.context;
using Microsoft.AspNetCore.Http;

namespace Group2.Controllers
{
    public class UsersController : Controller
    {
        private readonly hackertonDbContext _context;

        public UsersController(hackertonDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index(string searching)
        {
            return View(await _context.Users.Where(x => x.uniqueId.Contains(searching) || searching == null ).ToListAsync());

           // return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.serviceNo = HttpContext.Session.GetString("User");
           
            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }


            UsersDetailsViewModel viewModel = await GetGroupDetailsViewModelFromGroup(users);
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUserDetails([Bind("Id,UswerId,date,DocId,Institution,IsDiagnosed,Problem,Comment")] UserDetails userDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userDetails);
        }
        private async Task<UsersDetailsViewModel> GetGroupDetailsViewModelFromGroup(Users users)
        {
            UsersDetailsViewModel viewModel = new UsersDetailsViewModel();
            viewModel.users = users;


            var ll = users.Id.ToString();


            List<UserDetails> contacts = await _context.userDetails.Where(m => m.UswerId == ll).ToListAsync();
            viewModel.UserDetails = contacts;
            return viewModel;
        }
        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult reffer()
        {
            return View();
        }
        public IActionResult reschedule()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fULL_NAME,d_O_b,GENDER,uSERNAME,ROLE,uniqueId,LOCATION,PHONE")] Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,fULL_NAME,d_O_b,GENDER,uSERNAME,ROLE,uniqueId,LOCATION,PHONE")] Users users)
        {
            if (id != users.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.Id))
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
            return View(users);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var users = await _context.Users.FindAsync(id);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
