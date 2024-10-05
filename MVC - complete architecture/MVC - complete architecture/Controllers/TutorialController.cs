using Microsoft.AspNetCore.Mvc;
using MVC___complete_architecture.Models;
using MVC___complete_architecture.Repository;
using MVC___complete_architecture.ViewModels;

namespace MVC___complete_architecture.Controllers;

public class TutorialController : Controller
{
    private readonly ITutorialRepository _tourRepository;

    public TutorialController(ITutorialRepository tutorialRepository)
    {
        _tourRepository = tutorialRepository;
    }

    public IActionResult Index()
    {
        
        // ViewData + ViewBag = small amount of data
        // ViewModel = large amount of data

      // var tutorials = new TutorialRepository().getAllTutorial();
      var tutorials = _tourRepository.getAllTutorial();
        return View(tutorials);
    }
}