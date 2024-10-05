using MVC___complete_architecture.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC___complete_architecture.Context
{
    public class TutorialDbContext : DbContext
    {
        public TutorialDbContext(DbContextOptions<TutorialDbContext> options) : base(options)
        {

        }

        public DbSet<Tutorial> Tutorials { get; set; }
    }
}
