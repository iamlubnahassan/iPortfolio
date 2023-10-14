using System.ComponentModel.DataAnnotations;

namespace iportfolio.Model
{
    public class Service
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="please Enter Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "please Enter IconName")]
        public string IconName { get; set; }
    }
}
