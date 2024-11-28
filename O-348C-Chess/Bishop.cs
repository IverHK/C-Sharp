namespace O_348C_Chess;

public class Bishop(string symbol) : Piece(symbol)
{
    public override bool Move(string fromPosition, string toPosition)
    {
        var diffCol = fromPosition[0] - toPosition[0]; 
        var diffRow = fromPosition[1] - toPosition[1]; 
        return Math.Abs(diffRow) == Math.Abs(diffCol);
    }
}