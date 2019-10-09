using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChooseYourOwnAdventure.Models;
using System.Security.Claims;
using ChooseYourOwnAdventure.Data;

namespace ChooseYourOwnAdventure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var loggedIn = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (String.IsNullOrEmpty(loggedIn))
            {
                return View();
            }

            var userProfile = _context.Accounts.Where(x => x.UserId == loggedIn).FirstOrDefault();
           
            if (userProfile == null)
            {
                return RedirectToAction("Create", "Accounts");
            }

            return View();
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
