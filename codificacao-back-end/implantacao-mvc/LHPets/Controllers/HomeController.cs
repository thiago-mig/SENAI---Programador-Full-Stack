using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets.Models;

namespace LHPets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Thomas Shelby", "111.111.111-11", "thomassh@mail.com", "toto");
        Cliente cliente2 = new Cliente(01, "Arthur Shelby", "222.222.222-22", "arthursh@mail.com", "spark");
        Cliente cliente3 = new Cliente(01, "Jhon Shelby", "333.333.333-33", "jhonsh@mail.com", "rufus");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet Sa", "11.111.111/0001-11", "cps@mail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Alphadog ltda", "22.222.222/0002-22", "alphad@mail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Petz SA", "33.333.333/0003-33", "petz@mail.com");

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);

        ViewBag.listaFornecedor = listaFornecedor;
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
