namespace Community.PowerToys.Run.Plugin.Wiktionary;

/// <summary>
/// Public APIs that all PowerToys Run plugins must implement
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Gets the plugin name
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the plugin description
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Initialize the plugin
    /// </summary>
    /// <param name="context">Plugin context</param>
    void Init(PluginInitContext context);

    /// <summary>
    /// Query handler for the plugin
    /// </summary>
    /// <param name="query">Query information</param>
    /// <returns>List of results</returns>
    List<Result> Query(Query query);
}
