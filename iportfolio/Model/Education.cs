using System.ComponentModel.DataAnnotations;

namespace iportfolio.Model
{
    public class Education
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Degree")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "Please enter StartYear")]
        public string StartYear { get; set; }
        [Required(ErrorMessage = "Please enter EndYear")]
        public string EndYear { get; set; }

        [Required(ErrorMessage = "Please enter Institute")]
        public string InstituteName { get; set; }

        [Required(ErrorMessage = "Please enter Desc")]

        public string Desc { get; set; }
    }
}
