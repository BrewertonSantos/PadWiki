namespace PadWiki.WebApp.Entities;

public class CharmLevel
{
    // Private Parameters
    private int FirstCharmUpgrade { get; set; } = 0;
    private int SecondCharmUpgrade { get; set; } = 0;
    private int ThirdCharmUpgrade { get; set; } = 0;

    // Constructors
    public CharmLevel() {}
    
    public CharmLevel(int firstCharmUpgrade, int secondCharmUpgrade, int thirdCharmUpgrade)
        => (FirstCharmUpgrade, SecondCharmUpgrade, ThirdCharmUpgrade) =
            (firstCharmUpgrade, secondCharmUpgrade, thirdCharmUpgrade);

    // Overloads
    public static implicit operator string?(CharmLevel charmLevel) =>
        (charmLevel.FirstCharmUpgrade, charmLevel.SecondCharmUpgrade, charmLevel.ThirdCharmUpgrade) switch
        {
            (0, 0, 0) => null,
            var (first, second, third) => $"{first}% | {second}% | {third}%"
        };
}