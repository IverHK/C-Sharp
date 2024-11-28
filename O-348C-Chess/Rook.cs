namespace O_348C_Chess;

internal class Rook : Piece
{
    internal Rook(string symbol) : base(symbol)
    {
    }

    internal override bool Move(string fromPosition, string toPosition)
    {
          return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
    }
}