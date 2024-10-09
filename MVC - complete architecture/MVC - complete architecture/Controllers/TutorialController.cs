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
        if (!ModelState.IsValid)
        {
            return View(tutorial);
        }
        Tutorial newTutorial = _tutorialRepository.Add(tutorial);
        return RedirectToAction("Index");
    }


    [HttpGet]

    public IActionResult EditTutorial(int id, string querystringData)
    {
        Tutorial tutorial = _tutorialRepository.getTutorial(id);
        return View(tutorial);
    }

    [HttpPost]

    public IActionResult EditTutorial(Tutorial modifiedData)
    {
        Tutorial tutorial = _tutorialRepository.getTutorial(modifiedData.Id);
            tutorial.Name = modifiedData.Name;
            tutorial.Description = modifiedData.Description;
            Tutorial updateTutorial = _tutorialRepository.Update(tutorial);
            return RedirectToAction("Index");
    }

    public IActionResult DeleteTutorial(int id)
    {
        Tutorial deleteTutorial = _tutorialRepository.Delete(id);
        return RedirectToAction("Index");
    }
}