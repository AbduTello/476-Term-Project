using System;

namespace DriveShare.Frontend.Services
{
    public class SessionStateService
    {
        // Store the user's session information (e.g., user token)
        public string? UserToken { get; set; }
        public string? UserId { get; set; }

        // Method to check if a user is logged in
        public bool IsUserLoggedIn()
        {
            return !string.IsNullOrEmpty(UserToken);
        }

        // Singleton pattern for session
        private static SessionStateService? _instance;

        public static SessionStateService Instance => _instance ??= new SessionStateService();
    }
}
