namespace O_329B_DynamicSquares;

public class Box
{
    internal int X { get; }
    internal int Y { get; }
    internal int StartY => Y;
    internal int EndY => Y + Height;
    internal int Width { get; }
    internal int Height { get; }
    private int _minimumSize = 3;

    public Box(Random random, int maxX, int maxY)
    {
        Width = random.Next(_minimumSize, maxX);
        Height = random.Next(_minimumSize, maxY);
        X = random.Next(0, maxX - Width);
        Y = random.Next(0, maxY - Height);
    }
}