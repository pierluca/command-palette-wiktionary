namespace Community.PowerToys.Run.Plugin.Wiktionary;

/// <summary>
/// Represents a user query
/// </summary>
public class Query
{
    /// <summary>
    /// Gets or sets the raw query string
    /// </summary>
    public string RawQuery { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the search terms (query without the action keyword)
    /// </summary>
    public string Search { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the action keyword used to trigger the plugin
    /// </summary>
    public string ActionKeyword { get; set; } = string.Empty;
}
