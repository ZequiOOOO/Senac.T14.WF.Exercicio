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

        var listaTO = DB.GetClientes();

        var listaCarros = new List<Models.Clientes>();

          foreach (var clientesTO in listaTO) {
              listaCarros.Add(
               new Models.Carros() { Id = clientesTO.Id, Nome = clientesTO.Nome,  Fabricante = clientesTO.Fabricante, Marca = clientesTO.Marca, Ano = clientesTO.Ano, Modelo = cliente  sTO.Modelo  }
                );
            };

    var ViewModel = new ClientesViewsModel() { ListCarros = listaClientess };
   
            return View(ViewModel);

}

public IActionResult NovoClietnes(int? id)
        {

            Models.Carros? Cliente = null;

            if (id != null)
            {
                var db = new DB();

                var clienteTO = db.GetClientesById(id.GetValueOrDefault());

                Cliente= new Models.Clientes()
                {
                    Id = ClientesTO.Id,
                    Nome = CLientesTO.Nome,
                    Marca = ClientesTO.Marca,
                    Fabricante = ClientesTO.Fabricante,
                    Modelo =ClientesTO.Modelo,
                };
            }
            return View(Cliente);
        }


        public IActionResult PersistirCarro(int? id, string nome, string modelo, string fabricante, string marca, int ano)
        {
             var DB = new DB();

            if (id == null)
            {
                var novoCarro = new ClientesTO()
                {
                    Nome = nome,
                    Ano = ano,
                    Fabricante = fabricante,
                    Marca = marca,
                    Modelo = modelo,
                    Id = _lastId,
                };
                DB.AddClientes(novoCarro);
            }
            else
            {
                var  alterarCarro  = DB.GetClientesById(id.GetValueOrDefault());

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
