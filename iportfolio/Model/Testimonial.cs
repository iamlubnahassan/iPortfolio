using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iportfolio.Model
{
    public class Testimonial
    {
        internal object photo;

        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Designation")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Please Enter Testimonial")]
        public string theTestimonial { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please Select Photo ")]
        public IFormFile? Photo { get; set; }
    }
}
