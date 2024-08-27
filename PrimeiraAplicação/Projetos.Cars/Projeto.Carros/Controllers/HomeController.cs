using Microsoft.AspNetCore.Mvc;
using Projeto.Carros.Models;
using System.Diagnostics;

namespace Projeto.Carros.Controllers
{
    public class HomeController : Controller
    { 
    private static List<Models.Carros> _list = new List<Models.Carros>()

      {
             new Models.Carros { Id = 1, Nome = "Astra", Marca = "Chevrolet"},
             new Models.Carros { Id = 2, Nome = "Audi a4 Sedan", Marca= "Audi"},
             new Models.Carros { Id = 3, Nome = "landau", Marca = "Ford"},
        };


    
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    public IActionResult CadastroCarro();
        {
            return Views();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
