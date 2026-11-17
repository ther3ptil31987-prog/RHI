namespace RenoDXCommander.Models;

/// <summary>
/// A single row in the Available Mods dialog.
/// Represents a game that has a RenoDX mod (named, UE-Extended or Unity), a Luma mod, an Ultra+ mod, or any combination.
/// </summary>
public record HdrModEntry(
    string  Name,
    /// <summary>"Done", "WIP", or null (not available).</summary>
    string? RenoDXStatus,
    string? RenoDXUrl,
    /// <summary>"Done", "WIP", or null (not available).</summary>
    string? LumaStatus,
    string? LumaUrl,
    /// <summary>Ultra+ page URL, or null when the game has no Ultra+ mod.</summary>
    string? UltraPlusUrl = null)
{
    public bool HasRenoDX    => RenoDXStatus != null;
    public bool HasLuma      => LumaStatus   != null;
    public bool HasUltraPlus => UltraPlusUrl != null;
}
