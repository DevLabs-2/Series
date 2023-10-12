using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Series.Models;

namespace Series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.listSeries = BD.GetSeries(); 
        return View();
    }

    public List<Temporada> VerTemporadas(int IdSerie){
        return ViewBag.response = BD.GetTemporadas(IdSerie);
    }
     public List<Actor> VerActores(int IdSerie){
        return ViewBag.response = BD.GetActores(IdSerie);
    }
    public Serie VerInfo(int IdSerie){
        return ViewBag.response = BD.GetInfoSerie(IdSerie);
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
