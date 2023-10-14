using System.ComponentModel.DataAnnotations;

namespace iportfolio.Model
{
    public class SocialNetwork
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter facebook Id")]
        public string Facebook { get; set; }

        [Required(ErrorMessage = "Enter Twitter Id")]
        public string Twitter { get; set; }

        [Required(ErrorMessage = "Enter LinkedIn Id")]
        public string LinkedIn { get; set; }
        [Required(ErrorMessage = "Enter Skype Id")]
        public string Skype { get; set; }


    }
}
