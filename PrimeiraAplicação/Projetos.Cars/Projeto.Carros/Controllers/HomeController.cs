using Microsoft.AspNetCore.Mvc;
using Projeto.Carros.Models;
using System.Diagnostics;

namespace Projeto.Carros.Controllers
{
    public class HomeController : Controller
    { 
        private static List<Models.Carros> _list = new List<Models.Carros>()
        {
            new Models.Carros() { Id = 1, Nome = "Astra", Marca = "Chevrolet"},
            new Models.Carros() { Id = 2, Nome = "Audi a4 Sedan", Marca= "Audi"},
            new Models.Carros() { Id = 3, Nome = "landau", Marca = "Ford"},
        };

        private static int _lastId = 101;

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

        public IActionResult Carro()
        {  var ViewModel = new CarrosViewsModel () { ListCarros = _list };
            return View(ViewModel);
        }
       
        public IActionResult NovoCarro(int? id)
        {
            var carro = _list.Where(carro => carro.Id == id).FirstOrDefault();

            return View(carro);
        }

        public IActionResult PersistirCarro(int? id, string nome, string modelo, string fabricante, string marca, int ano)
        {
            if (id == null)
            {
                var novoCarro = new Models.Carros()
                {
                    Nome = nome,
                    Ano = ano,
                    Fabricante = fabricante,
                    Marca = marca,
                    Modelo = modelo,
                    Id = _lastId,
                };
                _lastId++;
                _list.Add(novoCarro);
            }
            else
            {
               var carroEditar = _list.Where(carro => carro.Id == id).FirstOrDefault();
                carroEditar.Nome = nome;
                carroEditar.Modelo = modelo;
                carroEditar.Fabricante = fabricante;
                carroEditar.Ano = ano;  
                carroEditar.Marca = marca;
            }

            return RedirectToAction("Carro");
        }

        public IActionResult Deletar(int? id)
        {
            var carro = _list.Where(carro => carro.Id == id).FirstOrDefault();

            _list.Remove(carro);

            return RedirectToAction("Carro");
        }
    }
}
