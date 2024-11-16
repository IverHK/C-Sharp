namespace O_323C_ThreeInARowGame;

internal class Square
{
    internal char CurrentSquare = ' ';
    private const char _playerOne = '\u00d7';
    private const char _playerTwo = 'o';
    
    internal bool SquareIsOpen()
    {
        if (CurrentSquare == ' ') return true;
        return false;
    }
    internal bool SquareOwner()
    {
        if (CurrentSquare == _playerOne) return true;
        return false;
    }

    internal char ChooseSquare(bool player)
    {
        if (SquareIsOpen() && player) return _playerOne;
        return _playerTwo;
    }
}