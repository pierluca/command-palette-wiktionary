namespace Community.PowerToys.Run.Plugin.Wiktionary;

/// <summary>
/// Plugin initialization context
/// </summary>
public class PluginInitContext
{
    /// <summary>
    /// Gets or sets the plugin ID
    /// </summary>
    public string PluginId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the current culture info
    /// </summary>
    public string CurrentCulture { get; set; } = "en-US";
}
