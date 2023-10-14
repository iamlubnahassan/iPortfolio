using System.ComponentModel.DataAnnotations;

namespace iportfolio.Model
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage="please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "please Enter subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "please Enter Message ")]
        public string Message { get; set; }
    }
}
