using Microsoft.AspNetCore.Mvc;
using MVC___complete_architecture.Models;

namespace MVC___complete_architecture.Controllers;

public class TutorialController : Controller
{
    [ViewData]

    public string title { get; set; }

    public IActionResult Index()
    {
        
        // ViewData + ViewBag = small amount of data
        // ViewModel = large amount of data


   //
   //var tutorials = new List<Tutorial>()
   //    {
   //        new Tutorial { Id = 1, Name = "C#", Description = "C# tutorial" },
   //        new Tutorial { Id = 1, Name = "Asp.net core", Description = "Asp.net core" }
   //    };
   //
   //    //ViewData["title"] = "Tutorial Details";
   //
   //    title = "Tutorials Details";
   //
   //    //ViewData["tutorials"] = tutorials;
   //
   //    ViewBag.Tutorials = tutorials;

   var newModel = new Tutorial
   {
       Id = 1,
       Name = ".Net app",
       Description = "zlo"
   };

        return View(newModel);
    }
}