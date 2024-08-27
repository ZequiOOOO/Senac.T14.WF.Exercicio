using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicaçãoWebMVC.Models;
using System.Diagnostics;

namespace PrimeiraAplicaçãoWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private static List<Usuario> _list = new List<Usuario>()
        {
             new Usuario() { Id = 1, nome = "Dom Juan", email = "DonJuan@gmail.com"},
             new Usuario() { Id = 2, nome = "Diogo", email = "diogo22@gamial.com"},
             new Usuario() { Id = 3, nome = "Homer", email = "homerSimp@gmail.com"},
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
        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult NovoUsuario(int? id)
        {

            Usuario? usuario = null;

            if (id != null)
            {
                usuario = _list.Where(w => w.Id == id).FirstOrDefault();
            }
            return View(usuario);
        }

        public IActionResult PersistirUsuario(int? id, string nome, string email)
        {
            if (id == null)
            {
                var novoUsuario = new Usuario()
                {
                    Id = _list.Count + _list.Last().Id,
                    nome = nome,
                    email = email
                };
                _list.Add(novoUsuario);
            }
            else
            {
                var usuario = _list.Where(w => w.Id == id).FirstOrDefault();
                usuario.nome = nome;
                usuario.email = email;
            }

            return RedirectToAction("Usuario");
        }

   
        public IActionResult Usuario()
        {
            var ViewModel = new UsuarioViewModel() { ListUsuario = _list };

            return View(ViewModel);

        }

        public IActionResult Deletar(int Id)
        {
            var usuario = _list.Where(w => w.Id == Id).FirstOrDefault();

            _list.Remove(usuario);

            return RedirectToAction("Usuario"); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
