using MVC___complete_architecture.Context;
using MVC___complete_architecture.Models;

namespace MVC___complete_architecture.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialDbContext _context;
        public TutorialRepository(TutorialDbContext context)
        {
            _context = context;
            
        }


        public Tutorial Add(Tutorial tutorial)
        {
            throw new NotImplementedException();
        }

        public Tutorial Update(Tutorial tutorial)
        {
            throw new NotImplementedException();
        }

        public Tutorial Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Tutorial getTutorial(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> getAllTutorial()
        {
            return _context.Tutorials;
        }
    }
}
