using MVC___complete_architecture.ViewModels;
using MVC___complete_architecture.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC___complete_architecture.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public ArticleViewModel()
        {
            tutorials = new List<Tutorial>();
        }

        [Required(ErrorMessage = "Please enter article title")]
        [Display(Name = "Please enter article title")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Please enter article content")]
        [Display(Name = "Write article")]
        public string ArticleContent { get; set; }
        public int TutorialId { get; set; }
        public List<Tutorial> tutorials { get; set; }
    }
}