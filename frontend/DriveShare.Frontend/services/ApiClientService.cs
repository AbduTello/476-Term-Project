using System.Net.Http;

namespace DriveShare.Frontend.Services
{
    public class ApiClientService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = "http://localhost:5155"; // Set the base URL here
        }

        // Method to call API and get the response
        public async Task<T> GetAsync<T>(string route)
        {
            var response = await _httpClient.GetAsync(_baseUrl + route);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> PostAsync<T>(string route, object data)
        {
            var response = await _httpClient.PostAsJsonAsync(_baseUrl + route, data);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}
