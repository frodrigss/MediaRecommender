## MediaRecommender

MediaRecommender is a simple, console-based C# program that generates personalized recommendations for movies, books and series based on user preferences. It's a small, educational project that demonstrates API usage, prompt construction and console interaction.

---

## Table of Contents

- [Features](#features)
- [How It Works](#how-it-works)
- [Installation](#installation)
- [Usage](#usage)
- [Code Structure](#code-structure)
- [Best Practices Followed](#best-practices-followed)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- User preferences input for movies, books, series and streaming platforms.
- Gemini API integration for generating recommendations.
- Simple interactive loop allowing retry or exit.
- Basic error handling and clear user prompts.

---

## How It Works

1. The program asks for a Gemini API key.
2. The user provides preferences for movies, books, series and streaming platforms.
3. The app builds a prompt from those preferences and sends it to the Gemini API (via `GeminiService`).
4. Recommendations returned by the API are displayed in the console.

---

## Installation

1. Clone this repository:

```bash
git clone https://github.com/frodrigss/MediaRecommender.git
```

2. Open the solution in Visual Studio, Rider, or your preferred C# IDE.

3. Make sure you have the .NET SDK (this project targets .NET 9.0 based on the repository contents).

4. Obtain a Gemini API key and keep it ready when running the program.

---

## Usage

From the project root (where the .csproj file is located) run:

```powershell
dotnet run
```

Follow the prompts:
- Paste your Gemini API key.
- Enter your preferences for movies, books, series and streaming platforms.
- Wait a few seconds while the app generates recommendations.
- Choose 1 to generate again or 2 to exit.

If you get an error about a locked executable during build, see the Helper script section below.

---

## Code Structure

- `Program.cs` — Main entry: user prompts, loop, and display of recommendations.
- `Services/GeminiService.cs` — Encapsulates communication with the Gemini API.
- `Models/UserPreferences.cs` — Data model for user preferences.


---

## Contributing

Contributions are welcome. Typical workflow:

```bash
git checkout -b feature-name
# make changes
git commit -m "Describe change"
git push origin feature-name
# open a PR
```

Please test locally and keep changes focused and well-documented.

---

## License

This project is released under the MIT License. See the `LICENSE` file for details.
