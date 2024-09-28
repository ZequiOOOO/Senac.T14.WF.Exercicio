using Microsoft.AspNetCore.Mvc;
using Projeto.Carros.Models;
using System.Diagnostics;
using Servico;
using Servico.Model;

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
          {

        var DB = new DB();

        var listaTO = DB.GetCarros();

        var listaCarros = new List<Models.Carros>();

          foreach (var carrosTO in listaTO) {
              listaCarros.Add(
               new Models.Carros() { Id = carrosTO.Id, Nome = carrosTO.Nome,  Fabricante =carrosTO.Fabricante, Marca =carrosTO.Marca, Ano = carrosTO.Ano, Modelo= carrosTO.Modelo  }
                );
            };

    var ViewModel = new CarrosViewsModel() { ListCarros = listaCarros };
   
            return View(ViewModel);

}

public IActionResult NovoCarro(int? id)
        {

            Models.Carros? Carro = null;

            if (id != null)
            {
                var db = new DB();

                var carrosTO = db.GetCarrosById(id.GetValueOrDefault());

                Carro= new Models.Carros()
                {
                    Id = carrosTO.Id,
                    Nome = carrosTO.Nome,
                    Marca = carrosTO.Marca,
                    Fabricante = carrosTO.Fabricante,
                    Modelo = carrosTO.Modelo,
                };
            }
            return View(Carro);
        }


        public IActionResult PersistirCarro(int? id, string nome, string modelo, string fabricante, string marca, int ano)
        {
             var DB = new DB();

            if (id == null)
            {
                var novoCarro = new CarrosTO()
                {
                    Nome = nome,
                    Ano = ano,
                    Fabricante = fabricante,
                    Marca = marca,
                    Modelo = modelo,
                    Id = _lastId,
                };
                DB.AddCarros(novoCarro);
            }
            else
            {
                var  alterarCarro  = DB.GetCarrosById(id.GetValueOrDefault());

                alterarCarro.Nome = nome;
                alterarCarro.Modelo= modelo;
                alterarCarro.Fabricante = fabricante;
                alterarCarro.Ano = ano;
                alterarCarro.Marca = marca;

                DB.UpdateAlterarCarros(alterarCarro);
            }
         
            return RedirectToAction("Carro");
        }

        public IActionResult Deletar(int? id)
        {
            var DB = new DB();

            DB.DeletarCarros(id.GetValueOrDefault());

            return RedirectToAction("Carro");
        }
    }
}
