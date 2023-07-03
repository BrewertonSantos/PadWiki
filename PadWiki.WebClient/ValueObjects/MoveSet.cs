using PadWiki.WebClient.Entities;

namespace PadWiki.WebClient.ValueObjects;

public sealed class MoveSet
{
    public MoveSet(List<Move> moves, List<Move> passiveMoves, List<TechnicalMachine> tmLearnset, string tmRestrictions)
        => (Moves, PassiveMoves, TmLearnset, TmRestrictions) = (moves, passiveMoves, tmLearnset, tmRestrictions);

    public List<Move> Moves { get; private set; }
    public List<Move> PassiveMoves { get; private set; }
    public List<TechnicalMachine> TmLearnset { get; private set; }
    public string TmRestrictions { get; private set; }

    
}