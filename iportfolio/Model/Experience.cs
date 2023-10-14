using System.ComponentModel.DataAnnotations;

namespace iportfolio.Model
{
    public class Experience
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter JobTitle")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Please Enter Location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please Enter StartYear")]
        public string StartYear { get; set; }

        [Required(ErrorMessage = "Please Enter EndYear")]
        public string EndYear { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        public string Desc { get; set; }
    }
}
