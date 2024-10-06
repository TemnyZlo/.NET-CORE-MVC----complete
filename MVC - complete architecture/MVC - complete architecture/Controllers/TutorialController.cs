using Microsoft.AspNetCore.Mvc;
using MVC___complete_architecture.Models;
using MVC___complete_architecture.Repository;
using MVC___complete_architecture.ViewModels;

namespace MVC___complete_architecture.Controllers;

public class TutorialController : Controller
{
    private readonly ITutorialRepository _tutorialRepository;

    public TutorialController(ITutorialRepository tutorialRepository)
    {
        _tutorialRepository = tutorialRepository;
    }

    public IActionResult Index()
    {
        
        // ViewData + ViewBag = small amount of data
        // ViewModel = large amount of data

      var tutorials = _tutorialRepository.getAllTutorial();
        return View(tutorials);
    }


    [HttpGet]
    public IActionResult CreateTutorial()
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult CreateTutorial(Tutorial tutorial)
    {
        Tutorial newTutorial = _tutorialRepository.Add(tutorial);
        return RedirectToAction("Index");
    }
}