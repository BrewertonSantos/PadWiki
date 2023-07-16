using System.Globalization;

namespace PadWiki.WebApp.ValueObjects;

public class ResourceText : ValueObject
{
    #region Public properties

    public string EnglishUsa { get; init; }
    public string? PolishPoland { get; init; } = null;
    public string? PortugueseBrazil { get; init; } = null;
    public string? PortuguesePortugal { get; init; } = null;
    public string? RussianRussia { get; init; } = null;
    public string? SpanishMexico { get; init; } = null;

    #endregion

    #region Constructors
    
    public ResourceText(string englishUsa)
        => EnglishUsa = englishUsa;

    public ResourceText(
        string englishUsa,
        string? polishPoland,
        string? portugueseBrazil,
        string? portuguesePortugal,
        string? russianRussia,
        string? spanishMexico)
    {
        EnglishUsa = englishUsa;
        PolishPoland = polishPoland;
        PortugueseBrazil = portugueseBrazil;
        PortuguesePortugal = portuguesePortugal;
        RussianRussia = russianRussia;
        SpanishMexico = spanishMexico;
    }

    #endregion

    #region Overloads

    public static implicit operator string(ResourceText text)
    {
        CultureInfo currentCulture = CultureInfo.CurrentCulture;

        if (currentCulture.Equals(Configuration.Cultures.EnglishUsa))
            return text.EnglishUsa;
        if (currentCulture.Equals(Configuration.Cultures.PolishPoland))
            return text.PolishPoland ?? text.EnglishUsa;
        if (currentCulture.Equals(Configuration.Cultures.PortugueseBrazil))
            return text.PortugueseBrazil ?? text.EnglishUsa;
        if (currentCulture.Equals(Configuration.Cultures.PortuguesePortugal))
            return text.PortuguesePortugal ?? text.EnglishUsa;
        if (currentCulture.Equals(Configuration.Cultures.RussianRussia))
            return text.RussianRussia ?? text.EnglishUsa;
        if (currentCulture.Equals(Configuration.Cultures.SpanishMexico))
            return text.SpanishMexico ?? text.EnglishUsa;

        return text.EnglishUsa;
    }

    public static implicit operator ResourceText(string text) => new(text);

    #endregion
}