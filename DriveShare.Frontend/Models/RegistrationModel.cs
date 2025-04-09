using System.ComponentModel.DataAnnotations;

namespace DriveShare.Frontend.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Security question 1 is required")]
        public string SecurityQuestion1 { get; set; } = string.Empty;

        [Required(ErrorMessage = "Security question 2 is required")]
        public string SecurityQuestion2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "Security question 3 is required")]
        public string SecurityQuestion3 { get; set; } = string.Empty;
    }
}