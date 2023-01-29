using Microsoft.AspNetCore.Mvc;
using NLMKTest.Models;
using NLMKTest.Domain.Repos.Interfaces;

namespace NLMKTest.Controllers;

public class HomeController : Controller
{
    private readonly IEquipmentDowntimeRepo _downtimeRepo;

    public HomeController(IEquipmentDowntimeRepo downtimeRepo)=> _downtimeRepo = downtimeRepo;

    public IActionResult Index() => View(_downtimeRepo.GetAllEquipmentDowntimes());

    public IActionResult CreateEquipment() => View();
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateEquipment(EquipmentDowntime entity)
    {
        if (ModelState.IsValid)
        {
            _downtimeRepo.SaveEquipmentDowntime(entity);
            return RedirectToAction("Index", "Home");
        }
        return View(entity);
    }
    
    public IActionResult DeleteEquipment(int id)
    {
        _downtimeRepo.DeleteEquipment(id);
        return RedirectToAction("Index", "Home");
    }
}