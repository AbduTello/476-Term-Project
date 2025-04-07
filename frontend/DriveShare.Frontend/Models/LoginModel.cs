namespace DriveShare.Frontend.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class TokenResult
    {
        public string Result { get; set; }
    }

    public class LoginResponse
    {
        public TokenResult Token { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
    }
}