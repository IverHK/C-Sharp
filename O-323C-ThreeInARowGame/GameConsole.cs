namespace O_323C_ThreeInARowGame;

public class GameConsole
{
    internal static void Show(Board board)
    {
        Console.WriteLine("  A B C");
        Console.WriteLine(" \u250c\u2500\u2500\u2500\u2500\u2500\u2510");
        Console.WriteLine($"1\u2502{board.squares[0].CurrentSquare} {board.squares[1].CurrentSquare} {board.squares[2].CurrentSquare}\u2502");
        Console.WriteLine($"2\u2502{board.squares[3].CurrentSquare} {board.squares[4].CurrentSquare} {board.squares[5].CurrentSquare}\u2502");
        Console.WriteLine($"3\u2502{board.squares[6].CurrentSquare} {board.squares[7].CurrentSquare} {board.squares[8].CurrentSquare}\u2502");
        Console.WriteLine(" \u2514\u2500\u2500\u2500\u2500\u2500\u2518");
    }
}