using System.Text.Json.Serialization;

namespace RenoDXdbEditor;

/// <summary>
/// Serialization-only record for RenoDXdb-source.json.
/// Source Engine games all use the shared renodx-sourceengine addon;
/// Bitness says which build the game needs: "32", "64" or "both".
/// </summary>
public record SourceEntry(
    [property: JsonPropertyName("Name")]     string  Name,
    [property: JsonPropertyName("Status")]   string  Status,
    [property: JsonPropertyName("Bitness")]  string? Bitness,
    [property: JsonPropertyName("Comments")] string? Comments)
{
    /// <summary>Allowed Bitness values, in combo order.</summary>
    public static readonly string[] BitnessValues = ["32", "64", "both"];
}
