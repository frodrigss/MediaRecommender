using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace MediaRecommender.Services.GeminiService
{
    public class GeminiService
    {
        private readonly string apiKey;
        private readonly HttpClient http = new();
        private const string Endpoint = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent";

        public GeminiService(string apiKey) => this.apiKey = apiKey;

        public string GenerateRecommendations(string prompt)
        {
            var body = new
            {
                contents = new[]
                {
                    new { role = "user", parts = new[] { new { text = prompt } } }
                }
            };

            var content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
            var response = http.PostAsync($"{Endpoint}?key={apiKey}", content).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            using var doc = JsonDocument.Parse(json);
            return doc.RootElement
                     .GetProperty("candidates")[0]
                     .GetProperty("content")
                     .GetProperty("parts")[0]
                     .GetProperty("text")
                     .GetString() ?? "";
        }
    }
}