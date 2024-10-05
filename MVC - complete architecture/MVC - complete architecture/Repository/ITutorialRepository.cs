using MVC___complete_architecture.Models;

namespace MVC___complete_architecture.Repository
{
    public interface ITutorialRepository
    {
        Tutorial Add(Tutorial  tutorial);
        Tutorial Update(Tutorial tutorial);
        Tutorial Delete(int Id);
        Tutorial getTutorial(int Id);

        IEnumerable<Tutorial> getAllTutorial();

    }
}
