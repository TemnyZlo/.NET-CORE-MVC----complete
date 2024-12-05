using MVC___complete_architecture.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC___complete_architecture.ViewModels
{
    public class TutorialViewModel
    {
        //public Tutorial tutorial { get; set; }
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Please enter text")]
        [Required]
        [Display(Name = "Enter the name of tutorial")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Please describe your tutorial")]
        public string Description { get; set; }
    }
}
