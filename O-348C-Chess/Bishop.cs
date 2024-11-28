namespace O_348C_Chess;

internal class Bishop(string symbol) : Piece(symbol)
{
    internal override bool Move(string fromPosition, string toPosition)
    {
        var diffCol = fromPosition[0] - toPosition[0]; 
        var diffRow = fromPosition[1] - toPosition[1]; 
        return Math.Abs(diffRow) == Math.Abs(diffCol);
    }
}