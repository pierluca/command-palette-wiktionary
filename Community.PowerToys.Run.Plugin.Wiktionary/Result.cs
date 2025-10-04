using System.Windows.Input;

namespace Community.PowerToys.Run.Plugin.Wiktionary;

/// <summary>
/// Represents a search result
/// </summary>
public class Result
{
    /// <summary>
    /// Gets or sets the result title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the result subtitle
    /// </summary>
    public string SubTitle { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the icon path
    /// </summary>
    public string IcoPath { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the result score for ranking
    /// </summary>
    public int Score { get; set; }

    /// <summary>
    /// Gets or sets the action to perform when result is selected
    /// </summary>
    public Func<ActionContext, bool>? Action { get; set; }

    /// <summary>
    /// Gets or sets the context menu actions
    /// </summary>
    public List<ContextMenuResult>? ContextData { get; set; }
}

/// <summary>
/// Context for result action
/// </summary>
public class ActionContext
{
    /// <summary>
    /// Gets or sets special key states (e.g., Ctrl, Shift pressed)
    /// </summary>
    public ModifierKeys SpecialKeyState { get; set; }
}

/// <summary>
/// Represents a context menu result
/// </summary>
public class ContextMenuResult
{
    /// <summary>
    /// Gets or sets the plugin ID
    /// </summary>
    public string PluginId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the menu title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the glyph (icon)
    /// </summary>
    public string Glyph { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the keyboard accelerator
    /// </summary>
    public string AcceleratorKey { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the accelerator modifier
    /// </summary>
    public ModifierKeys AcceleratorModifiers { get; set; }

    /// <summary>
    /// Gets or sets the action to perform
    /// </summary>
    public Func<ActionContext, bool>? Action { get; set; }
}
