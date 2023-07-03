using System.Globalization;

namespace PadWiki.WebApp;

public static class Configuration
{
    public static class Cultures
    {
        public static readonly CultureInfo EnglishUsa = new("en-US");
        public static readonly CultureInfo PolishPoland = new("pl-PL");
        public static readonly CultureInfo PortugueseBrazil = new("pt-BR");
        public static readonly CultureInfo PortuguesePortugal = new("pt-PT");
        public static readonly CultureInfo RussianRussia = new("ru-RU");
        public static readonly CultureInfo SpanishMexico = new("es-MX");
    }
}