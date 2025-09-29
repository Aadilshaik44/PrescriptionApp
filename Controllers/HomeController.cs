using Microsoft.AspNetCore.Mvc;
using PrescriptionApp.Models;

namespace PrescriptionApp.Controllers
{
    public class HomeController : Controller
    {
        private PrescriptionContext context { get; set; }

        public HomeController(PrescriptionContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            var prescriptions = context.Prescriptions.ToList();
            return View(prescriptions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }

}
