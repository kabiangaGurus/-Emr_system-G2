using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group2.Models;
using Microsoft.AspNetCore.Http;
using Group2.context;

namespace Group2.Controllers
{
    public class HomeController : Controller
    {
        private readonly hackertonDbContext _context;
        public HomeController(hackertonDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginUser(Doc_Res user)
        {
            if (user.serviceNo == null || user.PASSWORD == null)
            {
                return Content("put user/pass");
            }
            var Username = user.serviceNo;

            TokenProvider TokenProvider = new TokenProvider(_context);

            var userToken = TokenProvider.LoginUser(user.serviceNo, user.PASSWORD);
            if (userToken == null)
            {

                return Content("Incorrect User Or Pass");

            }

            HttpContext.Session.SetString("JWToken", userToken);
           
            return Redirect("~/Users/Index");

        }
        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return Redirect("~/Home/Index");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
