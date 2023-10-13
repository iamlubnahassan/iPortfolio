using System.ComponentModel.DataAnnotations.Schema;

namespace iportfolio.Model
{
    public class Testimonial
    {
        internal object photo;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string theTestimonial { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
