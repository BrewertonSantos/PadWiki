using PadWiki.WebApp.Entities;

namespace PadWiki.WebApp.Services.Contracts;

/// <summary>
/// Defines the basic structure for a service that manages a collection of Quests.
/// </summary>
public interface ICaveService
{
    /// <summary>
    /// Stores all necessary information of caves and among other characteristics that may be relevant in the context.
    /// </summary>
    List<Cave> Caves { get; set; }

    /// <summary>
    /// Get a <see cref="Cave"/> by slug string.
    /// </summary>
    /// <param name="slug">Snake case string</param>
    /// <returns>An existing <see cref="Cave"/> object that match with the parameter.</returns>
    Cave? GetBySlug(string slug);

    /// <summary>
    /// Responsible for populating the Caves list.
    /// </summary>
    void PopulateCaves();
}