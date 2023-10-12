using System.IO;


namespace Penumbra.Api.Models;
public class ModDetails
{
    public string Name { get; set; } = string.Empty;

    public string ModPath { get; set; } = string.Empty;

    public int Index { get; set; }
    public int Priority { get; set; }

    public bool IsTemporary
        => Index < 0;

    public string Author { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public IReadOnlyList<string> ModTags { get; set; } = Array.Empty<string>();


    // Local Data
    public long ImportDate { get; set; }
    public IReadOnlyList<string> LocalTags { get; set; } = Array.Empty<string>();
    public string Note { get; set; } = string.Empty;
    public bool Favorite { get; set; } = false;

    public IReadOnlyDictionary<string, object?> ChangedItems = new SortedList<string, object?>();

    public string LowerChangedItemsString { get; set; } = string.Empty;
    public string AllTagsLower { get; set; } = string.Empty;

    public int TotalFileCount { get; set; }
    public int TotalSwapCount { get; set; }
    public int TotalManipulations { get; set; }
    public bool HasOptions { get; set; }

}
