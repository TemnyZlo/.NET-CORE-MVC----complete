using Microsoft.AspNetCore.Mvc;
using MVC___complete_architecture.Repository;

namespace MVC___complete_architecture.ViewComponents
{
    public class TutorialMenuViewComponent:ViewComponent
    {

        private readonly ITutorialRepository _tutorialRepository;

        public TutorialMenuViewComponent(ITutorialRepository tutorialRepository)
        {
               _tutorialRepository = tutorialRepository;
        }


        //synchonous method
        public IViewComponentResult Invoke()
        {
            var tutorials = _tutorialRepository.getAllTutorial().OrderBy(p => p.Name);
            return View(tutorials);
        }


        //asynchronous method

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    return View();
        //}
        //

    }
}
