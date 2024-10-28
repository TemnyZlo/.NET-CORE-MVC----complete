using System.ComponentModel.DataAnnotations;

namespace MVC___complete_architecture.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        [Required (ErrorMessage = "Please enter article title")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Please enter article content")]
        public string ArticleContent { get; set; }


        //setup relationship with Tutorial model/table
        public int TutorialId { get; set; } //Foreign key

        public Tutorial Tutorial { get; set; } //Reference navigation property

    }
}
