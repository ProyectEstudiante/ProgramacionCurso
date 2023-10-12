using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cursoProgramacion.Models;

namespace cursoProgramacion.Controllers;

public class ContactoController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ContactoController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Registrar(Contacto objcontacto){
        objcontacto.Response = "Grasias estaremos en contacto";
        return View("Index", objcontacto);
    }
}
