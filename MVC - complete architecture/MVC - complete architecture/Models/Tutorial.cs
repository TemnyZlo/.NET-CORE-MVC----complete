using System.Collections;

namespace MVC___complete_architecture.Models
{
    public class Tutorial : IEnumerable
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
