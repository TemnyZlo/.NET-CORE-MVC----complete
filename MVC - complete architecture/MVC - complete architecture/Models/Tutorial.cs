using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC___complete_architecture.Models
{
    public class Tutorial 
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        //data annotation
        [Display(Name = "Tutorial Description")]
        public string Description { get; set; }
        
    }
}
