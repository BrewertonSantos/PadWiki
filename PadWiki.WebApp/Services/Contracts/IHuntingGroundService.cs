using PadWiki.WebApp.Entities;

namespace PadWiki.WebApp.Services.Contracts;

/// <summary>
/// Defines the basic structure for a service that manages a collection of Quests.
/// </summary>
public interface IHuntingGroundService
{
    /// <summary>
    /// Stores all necessary information of caves and among other characteristics that may be relevant in the context.
    /// </summary>
    List<HuntingGround> HuntingGrounds { get; set; }

    /// <summary>
    /// Get a <see cref="HuntingGround"/> by slug string.
    /// </summary>
    /// <param name="slug">Snake case string</param>
    /// <returns>An existing <see cref="HuntingGround"/> object that match with the parameter.</returns>
    HuntingGround? GetBySlug(string slug);

    /// <summary>
    /// Responsible for populating the Caves list.
    /// </summary>
    void PopulateCaves();
}