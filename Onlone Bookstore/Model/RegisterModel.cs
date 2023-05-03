using System.ComponentModel.DataAnnotations;

namespace Onlone_Bookstore.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "email is required")]
        public string Email { get; set; }
    }
}
