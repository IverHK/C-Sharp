namespace O_348B_Shapes;

class Rectangle : Shape
{
    private int Width { get; set; }
    private int Height { get; set; }
    private int _minimumSize = 3;

    public Rectangle(Random random, int maxX, int maxY)
        : base(random)
    {
        X = random.Next(0, maxX - _minimumSize);
        Y = random.Next(0, maxY - _minimumSize);
        Width = random.Next(_minimumSize, maxX - X);
        Height = random.Next(_minimumSize, maxY - Y);
    }

    public Rectangle(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public override string GetCharacter(int row, int col)
    {
        // Top left corner
        if (row == Y && col == X) return "┌";
        // Top right corner
        if (row == Y && col == X + Width) return "┐";
        // Bottom left corner
        if (row == Y + Height && col == X) return "└";
        // Bottom right corner
        if (row == Y + Height && col == X + Width) return "┘";

        // Top line
        if (row == Y && col > X && col < X + Width) return "─";
        // Bottom line
        if (row == Y + Height && col > X && col < X + Width) return "─";
        // Left line
        if (col == X && row > Y && row < Y + Height) return "│";
        // Right line
        if (col == X + Width && row > Y && row < Y + Height) return "│";

        return null;
    }
}