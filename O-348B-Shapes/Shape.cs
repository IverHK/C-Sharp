namespace O_348B_Shapes;

abstract class Shape
{
    private int DirectionX { get; set; }
    private int DirectionY { get; set; }
    protected int X { get; set; }
    protected int Y { get; set; }

    protected Shape()
    {
    }

    protected Shape(Random random)
    {
        DirectionX = random.Next(0, 2);
        DirectionY = random.Next(0, 2);
    }

    public void Move()
    {
        X += DirectionX;
        Y += DirectionY;
    }

    public abstract string GetCharacter(int row, int col);
}