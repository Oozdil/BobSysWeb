using BobSysWeb.Data;
using BobSysWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BobSysWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WematchDbContext _context;

        public HomeController(ILogger<HomeController> logger, WematchDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           // List<DatabaseDetailModel> list=_context.DatabaseDetailModels.ToList();
            List<DatabaseDetailModel> list=_context.DatabaseDetailModels.Take(10).ToList();
            return View(list);
        }

     

        public IActionResult Detail(int id)
        {
            List<DatabaseDetailModel> list = _context.DatabaseDetailModels.ToList();
            DatabaseDetailModel dm = list.FirstOrDefault(x => x.weMatchid == id);
            ViewData["URL"] = " https://career-portal.wematch-intern.de/#/jobs/" + dm.weMatchid;
            return View(dm);
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
