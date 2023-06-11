namespace PadWiki.WebApp.Entities;

public class CharmLevel
{
    private int FirstCharmUpgrade { get; }
    private int SecondCharmUpgrade { get; }
    private int ThirdCharmUpgrade { get; }

    public CharmLevel(int firstCharmUpgrade, int secondCharmUpgrade, int thirdCharmUpgrade)
        => (FirstCharmUpgrade, SecondCharmUpgrade, ThirdCharmUpgrade) =
            (firstCharmUpgrade, secondCharmUpgrade, thirdCharmUpgrade);

    public static implicit operator string?(CharmLevel charmLevel) =>
        (charmLevel.FirstCharmUpgrade, charmLevel.SecondCharmUpgrade, charmLevel.ThirdCharmUpgrade) switch
        {
            (0, 0, 0) => null,
            var (first, second, third) => $"{first}% | {second}% | {third}%"
        };
}