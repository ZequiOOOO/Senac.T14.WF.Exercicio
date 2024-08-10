using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicaçãoWebMVC.Models;
using System.Diagnostics;

namespace PrimeiraAplicaçãoWebMVC.Controllers
{
    public class HomeController : Controller
    {
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
        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Usuario()
        {
            var Lista = new List<Usuario>()
            {
                new Usuario() { Id = 1, nome = "Dom Juan", email = "DonJuan@gmail.com"},
                new Usuario() { Id = 2, nome = "Diogo", email = "diogo22@gamial.com"},
                new Usuario() { Id = 3, nome = "Homer", email = "homerSimp@gmail.com"},
            };

            var ViewModel = new UsuarioViewModel() { ListUsuario = Lista };

            return View(ViewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
