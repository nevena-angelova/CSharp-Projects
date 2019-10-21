using System.ComponentModel.DataAnnotations;

namespace PANDA.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
