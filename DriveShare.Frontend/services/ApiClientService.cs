using System.Net.Http;
using System.Net.Http.Headers;

namespace DriveShare.Frontend.Services
{
    public class ApiClientService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private readonly SessionStateService _sessionState;

        public ApiClientService(HttpClient httpClient, SessionStateService sessionState)
        {
            _httpClient = httpClient;
            _baseUrl = "http://localhost:5155"; // base url
            _sessionState = sessionState;
        }

        // Method to set the Authorization header
        private void SetAuthorizationHeader()
        {
            if (_sessionState.IsUserLoggedIn() && !string.IsNullOrEmpty(_sessionState.UserToken))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _sessionState.UserToken);
            }
        }

        // Method to call API and get the response
        public async Task<T> GetAsync<T>(string route)
        {
            SetAuthorizationHeader(); // Set the Bearer token header
            var response = await _httpClient.GetAsync(_baseUrl + route);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> PostAsync<T>(string route, object data)
        {
            SetAuthorizationHeader(); // Set the Bearer token header
            var response = await _httpClient.PostAsJsonAsync(_baseUrl + route, data);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> PutAsync<T>(string route, object data)
        {
            SetAuthorizationHeader(); // Set the Bearer token header
            var response = await _httpClient.PutAsJsonAsync(_baseUrl + route, data);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}
