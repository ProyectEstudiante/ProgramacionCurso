using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cursoProgramacion.Models;

namespace cursoProgramacion.Controllers;

public class CalculadoraController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public CalculadoraController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}