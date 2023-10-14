using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iportfolio.Model
{
    public class Profoil
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Birthday")]
        public string Birthday { get; set; }

        [Required(ErrorMessage = "Please Enter Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please Enter Website")]
        
        public string Website { get; set; }

        [Required(ErrorMessage = "Please Enter Degree")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "Please Enter Phone")]
        [Phone(ErrorMessage ="Enter phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage ="Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter FreelanceStatus")]
        public string FreelanceStatus { get; set; }

        [Required(ErrorMessage = "Please Enter Description one ")]
        public string DescOne { get; set; }

        [Required(ErrorMessage = "Please Enter Descrption Two")]
        public string DescTwo { get; set; }

      
        public string? Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please Select Image")]
        public IFormFile? Photo { get; set; }
    }
}
