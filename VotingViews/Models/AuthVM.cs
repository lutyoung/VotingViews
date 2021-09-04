using System.ComponentModel.DataAnnotations;

namespace VotingViews.Models
{
    public class AuthVM
    {
        public class Register
        {
            [Required(ErrorMessage = "First Name is required")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Last Name is required")]
            public string LastName { get; set; }

            public string MiddleName { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
            public string Email { get; set; }

            public string Address { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [StringLength(255, ErrorMessage = "It must be 4 or above characters", MinimumLength = 4)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required(ErrorMessage = "Confirm Password is required")]
            [StringLength(255, ErrorMessage = "It must be 4 or above characters", MinimumLength = 4)]
            [DataType(DataType.Password)]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }
        }

        public class Login
        {
            [Required(ErrorMessage = "Email is required")]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [StringLength(255, ErrorMessage = "Incorrect Password", MinimumLength = 4)]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}