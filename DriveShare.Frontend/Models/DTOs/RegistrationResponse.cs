namespace DriveShare.Frontend.Models.DTOs
{
    public class RegistrationResponse
    {
        // Indicates whether the registration was successful
        public bool Success { get; set; }

        public string Message { get; set; } = string.Empty;

        // List of error messages (e.g., "Email already taken", "Password is too weak", etc.)
        public List<string> Errors { get; set; } = new List<string>();

        // Optional: Additional data you might want to return (e.g., User ID, Token, etc.)
        public string? UserId { get; set; }

        // Optional: Token or other success-related data
        public string? Token { get; set; }
    }
}
