namespace O_329B_DynamicSquares;

internal class VirtualScreenRow
{
    private VirtualScreenCell[] _cells;

    internal VirtualScreenRow(int screenWidth)
    {
        _cells = new VirtualScreenCell[screenWidth];
        
        for (int i = 0; i < screenWidth; i++)
        {
            _cells[i] = new VirtualScreenCell();
        }
    }

    internal void AddBoxTopRow(int boxX, int boxWidth)
    {
        for (int i = 0; i < boxX; i++)
        {
            _cells[i].GetCharacter();
        }
        
        _cells[boxX].AddUpperLeftCorner();
        _cells[boxX].GetCharacter();
        
        for (int i = boxX+1; i < boxWidth+boxX; i++)
        {
            _cells[i].AddHorizontal();
            _cells[i].GetCharacter();
        }
        _cells[boxX+boxWidth].AddUpperRightCorner();
        _cells[boxX+boxWidth].GetCharacter();
    }

    internal void AddBoxBottomRow(int boxX, int boxWidth)
    {
        for (int i = 0; i < boxX; i++)
        {
            _cells[i].GetCharacter();
        }

        _cells[boxX].AddLowerLeftCorner();
        _cells[boxX].GetCharacter();
        
        for (int i = boxX+1; i < boxWidth+boxX; i++)
        {
            _cells[i].AddHorizontal();
            _cells[i].GetCharacter();
        }
        _cells[boxX+boxWidth].AddLowerRightCorner();
        _cells[boxX+boxWidth].GetCharacter();
    }

    internal void AddBoxMiddleRow(int boxX, int boxWidth)
    {
        for (int i = 0; i < boxX; i++)
        {
            _cells[i].GetCharacter();
        }
        
        _cells[boxX].AddVertical();
        _cells[boxX].GetCharacter();
        
        for (int i = boxX+1; i < boxWidth+boxX; i++)
        {
            _cells[i].GetCharacter();
        }
        _cells[boxX+boxWidth].AddVertical();
        _cells[boxX+boxWidth].GetCharacter();
        
    }

    internal void Show()
    {
        foreach (var cell in _cells)
        {
            Console.Write(cell.GetCharacter());
        }
        Console.WriteLine();
    }
}