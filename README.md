# Text Adventure Game

A small console-based text adventure written in C# targeting .NET 8.

## Features
- Console-driven interactive story and puzzles
- Multiple floors with riddles and branching progress
- Simple, extendable class-per-floor structure
- Written for `C# 12` on `.NET 8`

## Requirements
- .NET 8 SDK installed (download from https://dotnet.microsoft.com/)
- Visual Studio 2022 (or later) recommended for editing and debugging
- Windows / macOS / Linux (console app; cross-platform via .NET 8)

## Getting started

1. Clone the repository:
2. Open the solution in Visual Studio:
3. Or run from the command line:
   - `cd <project-folder>` (the folder that contains the project `.csproj`)
   - `dotnet restore`
   - `dotnet run`

## How to play
- The game runs in the console. Read prompts and type your choices, then press Enter.
- Progress through floors by answering riddles and making decisions.
- Press the key requested to continue at end screens (e.g., epilogue).

All major gameplay units are implemented as small classes so adding new floors or scenes is straightforward.

## Extending the game
- Add a new floor: create `SeventhFloor.cs` with a public class and a method that runs the floor logic.
- Wire the new floor into `Program.cs` where floor progression is controlled.
- Follow the existing pattern for input parsing and user prompts.

## Coding notes
- Project currently uses `C# 12` features where appropriate and targets `.NET 8`.
- Keep console I/O simple and centralized to make unit testing easier if you later extract logic from UI.

## Troubleshooting
- If the app fails to build, ensure the machine has the correct .NET SDK version (`dotnet --info`).
- In Visual Studio: ensure the solution's project target framework is set to `.NET 8` under Project Properties.

## Contributing
- Open issues for bugs or feature requests.
- For changes, create a branch, implement tests where feasible, and submit a pull request with a clear description.

## License
This project is provided under the MIT License.

## Credits
Created using Visual Studio and .NET. Thanks to everyone who enjoys debugging with coffee.
