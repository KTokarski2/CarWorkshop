using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers;

public class CarWorkshopController : Controller
{

    private readonly ICarWorkshopService _carWorkshopService;

    public CarWorkshopController(ICarWorkshopService carWorkshopService)
    {
        _carWorkshopService = carWorkshopService;
    }

    public async Task<IActionResult> Index()
    {
        var carWorkshop = await _carWorkshopService.GetAll();
        return View(carWorkshop);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create(CarWorkshopDto carWorkshop)
    {

        if (!ModelState.IsValid)
        {
            return View();
        }
        
        await _carWorkshopService.Create(carWorkshop);
        return RedirectToAction(nameof(Create)); // TODO: refactor
    }
}