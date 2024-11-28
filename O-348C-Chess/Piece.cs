namespace O_348C_Chess;

public abstract class Piece
{
    internal string Symbol { get; }

    protected Piece(string symbol)
    {
        Symbol = symbol;
    }

    internal abstract bool Move(string fromPosition, string toPosition);
}
