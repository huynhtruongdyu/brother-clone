using Brother.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Brother.Controllers
{
#pragma warning disable CA1515 // Consider making public types internal
    public class HomeController : Controller
#pragma warning restore CA1515 // Consider making public types internal
    {
        public IActionResult Index()
        {
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
