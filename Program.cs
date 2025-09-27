using System;
using MediaRecommender.Models.Preferences;
using MediaRecommender.Services.GeminiService;

class Program
{
    static void Main()
    {
        Console.Write("Enter your Gemini API Key: ");
        string apiKey = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            Console.WriteLine("API Key is required. Exiting.");
            return;
        }

        var userPreferences = new UserPreferences();
        var gemini = new GeminiService(apiKey);

        while (true)
        {
            try
            {
                Console.Write("Movies: ");
                userPreferences.Movies = Console.ReadLine() ?? "";

                Console.Write("Books: ");
                userPreferences.Books = Console.ReadLine() ?? "";

                Console.Write("Series: ");
                userPreferences.Series = Console.ReadLine() ?? "";

                Console.Write("Streaming Platforms: ");
                userPreferences.PlatformStreaming = Console.ReadLine() ?? "";

                string prompt = $@"
                Movies Recommended: ...
                Books Recommended: ...
                Series Recommended: ...

                My preferences:
                - Movies: {userPreferences.Movies}
                - Books: {userPreferences.Books}
                - Series: {userPreferences.Series}
                - Streaming Platforms: {userPreferences.PlatformStreaming}

                Rules:
                - Only fill the template, no extra comments.
                - Provide 3-5 recommendations per category.
                - Specify streaming platforms when possible.";

                Console.WriteLine("\nGenerating recommendations...\n");
                string recommendations = gemini.GenerateRecommendations(prompt);
                Console.WriteLine(recommendations);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.Write("\n1 = Retry | 2 = Exit: ");
            string choice = Console.ReadLine()?.Trim();
            if (choice == "2") break;
        }
    }
}