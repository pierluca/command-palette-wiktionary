# Contributing to command-palette-wiktionary

Thank you for your interest in contributing to this PowerToys Run plugin!

## Getting Started

1. Fork the repository
2. Clone your fork
3. Create a new branch for your feature or bugfix
4. Make your changes
5. Test your changes
6. Submit a pull request

## Development Setup

### Prerequisites

- .NET 8.0 SDK or later
- PowerToys (for testing)
- Git
- A code editor (Visual Studio, VS Code, or Rider recommended)

### Building the Project

```bash
cd Community.PowerToys.Run.Plugin.Wiktionary
dotnet build
```

### Testing Your Changes

1. Build the plugin in Release mode:
   ```bash
   dotnet build --configuration Release
   ```

2. Copy the output to PowerToys plugins directory:
   ```bash
   xcopy /E /I /Y bin\Release\net8.0-windows %LOCALAPPDATA%\Microsoft\PowerToys\PowerToys Run\Plugins\Wiktionary
   ```

3. Restart PowerToys

4. Test the plugin with various search terms

## Code Style

This project follows standard C# coding conventions:

- Use 4 spaces for indentation
- Follow PascalCase for public members
- Follow camelCase for private fields (with `_` prefix)
- Add XML documentation comments for public APIs
- Keep methods focused and concise

The project includes an `.editorconfig` file that defines these rules.

## Pull Request Guidelines

- Ensure your code builds without errors or warnings
- Test your changes thoroughly
- Update documentation if needed
- Keep commits focused and atomic
- Write clear commit messages
- Reference any related issues

## Feature Requests and Bug Reports

Please use the GitHub Issues page to:

- Report bugs
- Suggest new features
- Ask questions

When reporting bugs, please include:

- Your Windows version
- PowerToys version
- Steps to reproduce the issue
- Expected behavior
- Actual behavior

## License

By contributing to this project, you agree that your contributions will be licensed under the MIT License.
