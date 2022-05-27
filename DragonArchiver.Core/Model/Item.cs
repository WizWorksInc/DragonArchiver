using System.Diagnostics.CodeAnalysis;

namespace DragonArchiver.Core.Model;

/// <summary>
/// An object representation of an Item in Dungeons and Dragons.
/// </summary>
internal class Item
{
    /// <summary>
    /// The constructor is mostly here for our deserialization of JSON.
    /// We treat all of our values as optional due to the fact that some fields
    /// may be empty as not every item has all of these as an option.
    /// We also check for NULL values.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="type"></param>
    /// <param name="rarity"></param>
    /// <param name="value"></param>
    /// <param name="source"></param>
    /// <param name="page"></param>
    /// <param name="entries"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public Item([NotNull] string name = null, [NotNull] string type = null, [NotNull] string rarity = null,
        [NotNull] string value = null, [NotNull] string source = null, int page = default,
        [NotNull] List<string> entries = null)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Type = type ?? throw new ArgumentNullException(nameof(type));
        Rarity = rarity ?? throw new ArgumentNullException(nameof(rarity));
        Value = value ?? throw new ArgumentNullException(nameof(value));
        Source = source ?? throw new ArgumentNullException(nameof(source));
        Page = page;
        Entries = entries ?? throw new ArgumentNullException(nameof(entries));
    }

    public string Name { get; set; }
    public string Type { get; set; }
    public string Rarity { get; set; }
    public string Value { get; set; }
    public string Source { get; set; }
    public int Page { get; set; }
    public List<string> Entries { get; set; }
}