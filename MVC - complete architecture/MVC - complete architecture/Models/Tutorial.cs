using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC___complete_architecture.Models
{
    public class Tutorial 
    {

        public int Id { get; set; }

        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please enter correct text")]
        [Required]
        [Display(Name ="Tutorial Name")]

        public string Name { get; set; }

        [Required]
        //data annotation
        [Display(Name = "Tutorial Description")]
        public string Description { get; set; }

       
        //Relationship - > Articles
        public List<Article> Articles { get; set; }
        
    }
}
