using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.MVC.Models;

namespace CarWorkshop.MVC.Controllers;

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

    public IActionResult About()
    {
        var model = new About()
        {
            Title = "Carworkshop application",
            Description = "Some description",
            Tags = new List<string>() { "#xd","#xdddd", "#super" }
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        var persons = new List<Person>()
        {
            new Person()
            {
                FirstName = "A",
                LastName = "AAAAAAAAAAA"
            },
            new Person()
            {
                FirstName = "D",
                LastName = "DDDDDDDDDDDD"
            },
            new Person()
            {
                FirstName = "Robert",
                LastName = "CCCCCCCCCC"
            }
        };
        return View(persons);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
