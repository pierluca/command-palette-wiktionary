using System.Diagnostics;
using System.IO;
using System.Web;

namespace Community.PowerToys.Run.Plugin.Wiktionary;

/// <summary>
/// Main plugin class for Wiktionary search
/// </summary>
public class Main : IPlugin
{
    private PluginInitContext? _context;
    private string _iconPath = string.Empty;

    /// <summary>
    /// Gets the plugin ID
    /// </summary>
    public static string PluginID => "4D52B66A36A641F1A905943207F16B0C";

    /// <summary>
    /// Gets the name of the plugin
    /// </summary>
    public string Name => "Wiktionary";

    /// <summary>
    /// Gets the description of the plugin
    /// </summary>
    public string Description => "Search Wiktionary for word definitions";

    /// <summary>
    /// Initialize the plugin
    /// </summary>
    /// <param name="context">Plugin context</param>
    public void Init(PluginInitContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "wiktionary.png");
    }

    /// <summary>
    /// Query handler
    /// </summary>
    /// <param name="query">Query information</param>
    /// <returns>List of results</returns>
    public List<Result> Query(Query query)
    {
        if (query == null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        var results = new List<Result>();
        var searchTerm = query.Search?.Trim();

        // Return empty if no search term
        if (string.IsNullOrWhiteSpace(searchTerm))
        {
            results.Add(new Result
            {
                Title = "Search Wiktionary",
                SubTitle = "Type a word to search on Wiktionary",
                IcoPath = _iconPath,
                Score = 100
            });
            return results;
        }

        // Create main result for opening Wiktionary
        var wiktionaryUrl = BuildWiktionaryUrl(searchTerm);
        results.Add(new Result
        {
            Title = $"Search Wiktionary for '{searchTerm}'",
            SubTitle = $"Open {wiktionaryUrl} in your browser",
            IcoPath = _iconPath,
            Score = 100,
            Action = _ =>
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = wiktionaryUrl,
                        UseShellExecute = true
                    });
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        });

        return results;
    }

    /// <summary>
    /// Build Wiktionary URL for the search term
    /// </summary>
    /// <param name="searchTerm">Search term</param>
    /// <returns>Wiktionary URL</returns>
    private static string BuildWiktionaryUrl(string searchTerm)
    {
        var encodedTerm = HttpUtility.UrlEncode(searchTerm);
        return $"https://en.wiktionary.org/wiki/{encodedTerm}";
    }
}
