namespace O_329B_DynamicSquares;

internal class VirtualScreenCell
{
    internal bool Up { get; private set; }
    internal bool Right { get; private set; }
    internal bool Down { get; private set; }
    internal bool Left { get; private set; }
    
    
    internal char GetCharacter()
    {
        if (Up && Down && Left && Right) return '\u253c';

        if (Up && Down && Left) return '\u2524';
        if (Down && Left && Right) return '\u252c';
        if (Down && Up && Right) return '\u251c';
        if (Up && Left && Right) return '\u2534';

        if (Up && Down) return '\u2502';
        if (Left && Right) return '\u2500';
        if (Down && Right) return '\u250c';
        if (Down && Left) return '\u2510';
        if (Up && Right) return '\u2514';
        if (Up && Left) return '\u2518';

        if (Up) return '\u2579';
        if (Down) return '\u257b';
        if (Left) return '\u2578';
        if (Right) return '\u257a';

        if (!Up && !Down && !Left && !Right) return ' ';

        return 'E';
    }

    internal void AddVertical()
    {
        Up = true;
        Down = true;
    }

    internal void AddHorizontal()
    {
        Left = true;
        Right = true;
    }

    internal void AddLowerLeftCorner()
    {
        Up = true;
        Right = true;
    }

    internal void AddUpperLeftCorner()
    {
        Down = true;
        Right = true;
    }

    internal void AddUpperRightCorner()
    {
        Down = true;
        Left = true;
    }

    internal void AddLowerRightCorner()
    {
        Up = true;
        Left = true;
    }
}
