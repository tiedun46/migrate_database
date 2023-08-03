using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MigrateDataPAKN.Models;
using MigrateDataPAKN.ModelsPostGre;
using MigrateDataPAKN.ModelsSQL;
using System.Diagnostics;

namespace MigrateDataPAKN.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhanAnhKienNghiContext _contextSQL;
        private readonly quanlyduanContext _contextPG;
        public HomeController(PhanAnhKienNghiContext contextSQL, quanlyduanContext contextPG)
        {
            _contextSQL = contextSQL;
            _contextPG = contextPG;
        }

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