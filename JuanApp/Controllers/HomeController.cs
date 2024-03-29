using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JuanApp.Controllers
{
    public class HomeController : Controller
    { 

        public IActionResult Index()
        {
            return View();
        }
    }
}
