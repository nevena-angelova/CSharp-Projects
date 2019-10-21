using PANDA.Services;
using System.ComponentModel.DataAnnotations;

namespace PANDA.Web.ViewModels
{
    public class RegisterViewModel
    {
        //private static Expression<Func<RegisterUserViewModelcs, User>> ()
        //{
        //    return x => new User
        //    {

        //    };
        //    }

        [Required]
        public string Username { get; set; }

        [Required]
        [RegularExpression(UserConstatnts.PasswordRegex)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
