using System.ComponentModel.DataAnnotations;

namespace iportfolio.Model
{
    public class Skill
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Percentage")]
        public int Percentage { get; set; }     
    }
}
