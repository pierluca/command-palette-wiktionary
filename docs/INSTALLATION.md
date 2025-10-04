# Installation Guide

## Prerequisites

- Windows 10 or later
- [PowerToys](https://github.com/microsoft/PowerToys) installed
- .NET 8.0 SDK (for building from source)

## Option 1: Install from Release

1. Download the latest release from the [Releases](https://github.com/pierluca/command-palette-wiktionary/releases) page
2. Extract the ZIP file
3. Copy the extracted folder to:
   ```
   %LOCALAPPDATA%\Microsoft\PowerToys\PowerToys Run\Plugins\
   ```
4. Restart PowerToys or go to PowerToys Settings > PowerToys Run > Plugins and reload plugins

## Option 2: Build from Source

1. Clone the repository:
   ```bash
   git clone https://github.com/pierluca/command-palette-wiktionary.git
   cd command-palette-wiktionary
   ```

2. Build the plugin:
   ```bash
   cd Community.PowerToys.Run.Plugin.Wiktionary
   dotnet build --configuration Release
   ```

3. Copy the build output to your PowerToys plugins directory:
   ```bash
   xcopy /E /I /Y bin\Release\net8.0-windows %LOCALAPPDATA%\Microsoft\PowerToys\PowerToys Run\Plugins\Wiktionary
   ```

4. Restart PowerToys

## Verify Installation

1. Open PowerToys Run (`Alt + Space`)
2. Type `wik test`
3. You should see the Wiktionary search option appear

## Troubleshooting

### Plugin doesn't appear in PowerToys Run

- Make sure PowerToys is running
- Check that the plugin files are in the correct directory
- Restart PowerToys completely (exit from system tray and restart)
- Check PowerToys Settings > PowerToys Run > Plugins to see if the plugin is listed

### Plugin appears but doesn't work

- Make sure you have .NET 8.0 Runtime installed
- Check that all DLL files are present in the plugin folder
- Check PowerToys logs for error messages

### Action keyword conflict

If the `wik` keyword conflicts with another plugin:

1. Go to PowerToys Settings > PowerToys Run > Plugins
2. Find "Wiktionary" in the plugin list
3. Click on it to modify settings
4. Change the action keyword to something else (e.g., `dict`, `define`)
