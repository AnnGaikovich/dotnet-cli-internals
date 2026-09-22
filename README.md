# Lab 1: .NET CLI & Platform

A modern console application demonstrating the core principles of the .NET CLI, project structure, and third-party package integration. Created as part of the first laboratory work on the .NET platform.

## Features

- **Animated Terminal UI:** Uses an animated spinner to simulate a loading and preparation process.
- **Visual Metrics:** Renders an interactive bar chart displaying student survival metrics (coffee consumed, compilation errors, CLI understanding).
- **Smart Time Calculation:** Dynamically calculates the time remaining until the 19:00 deadline and displays it using natural language phrasing (e.g., "5 hours, 30 minutes").

## Tech Stack

- **Framework:** .NET 10 (Target Framework: `net10.0`)
- **UI Library:** [Spectre.Console](https://spectreconsole.net/) — used for rendering rich terminal graphics, colors, and layout panels.
- **Text Formatting:** [Humanizer](https://github.com/Humanizr/Humanizer) — used for converting native `TimeSpan` objects into readable English sentences.

## Prerequisites

To run this project, you need to have the .NET SDK installed on your machine.

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- *(Optional)* .NET 8.0 SDK (for cross-version testing and `global.json` management)

## Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/AnnGaikovich/dotnet-cli-internals.git
   cd dotnet-cli-internals```
   
2. **Run the application:**

```bash
dotnet run```

3. **Publishing for Production:**
-To build a release version of the application into a specific folder;

   ```bash
   dotnet publish --configuration Release --output ./out```
   
### Project Structure

1. `Program.cs` — The entry point of the application containing C# top-level statements and UI rendering logic.
2. `Lab01.csproj` — The MSBuild project file defining the net10.0 target and NuGet package dependencies.
3. `.gitignore` — Configured to ignore compiled binaries (bin/, obj/) and custom output folders (out/) to keep the repository clean.

