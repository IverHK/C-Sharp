namespace O_323C_ThreeInARowGame;

class Board
{
    internal Square[] squares = new Square[9];
    private readonly Random _random = new Random();

    private enum Position
    {
        A1 = 0,
        A2 = 1,
        A3 = 2,
        B1 = 3,
        B2 = 4,
        B3 = 5,
        C1 = 6,
        C2 = 7,
        C3 = 8
    }

    internal Board()
    {
        for (int i = 0; i < squares.Length; i++)
        {
            squares[i] = new Square { CurrentSquare = ' '};
        }
    }

    internal void MarkRandom(bool player)
    {
        var randomNumber = _random.Next(0, 9);
        while (!squares[randomNumber].SquareIsOpen())
        {
            randomNumber = _random.Next(0, 9);
        }
        if (squares[randomNumber].SquareIsOpen())
        {
            squares[randomNumber].CurrentSquare = squares[randomNumber].ChooseSquare(player);
        }
    }

    internal void Mark(string position)
    {
        if (Enum.TryParse(position, true, out Position chosenPosition))
        {
            int index = (int)chosenPosition; 
            if (squares[index].SquareIsOpen())
            {
                squares[index].CurrentSquare = squares[index].ChooseSquare(true);
            }
            else
            {
                ChooseValidPosition();
            }
        }
        else
        {
            Console.WriteLine("Ugyldig posisjon. Velg en gyldig posisjon.");
            ChooseValidPosition();
        }
        
    }
    internal void ChooseValidPosition()
    {
        {
            Console.Write("Velg en ledig posisjon. Skriv inn hvor du vil sette kryss (f.eks. \"A2\"): ");
            string position = Console.ReadLine();
            Mark(position);
        }
    }

    internal bool IsGameFinished()
    {
        int[][] winningCombinations = new int[][]
        {
            new int[] { 0, 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8 },
            new int[] { 0, 3, 6 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 0, 4, 8 },
            new int[] { 2, 4, 6 },
        };
        foreach (var combo in winningCombinations)
        {
            if (squares[combo[0]].SquareOwner() &&
                squares[combo[0]].CurrentSquare == squares[combo[1]].CurrentSquare &&
                squares[combo[1]].CurrentSquare == squares[combo[2]].CurrentSquare)
            {
                Console.WriteLine("Du vant! Press Y for å spille igjen eller N for å avslutte.");
                char response = Convert.ToChar(Console.ReadLine());
                if (response == 'Y')
                {
                    Board board = new Board();
                    ResetBoard();
                    GameConsole.Show(board);
                }

                if (response == 'N') return false;
            }
            if (!squares[combo[0]].SquareOwner() &&
                squares[combo[0]].CurrentSquare == squares[combo[1]].CurrentSquare &&
                squares[combo[1]].CurrentSquare == squares[combo[2]].CurrentSquare && 
                squares[combo[1]].CurrentSquare != ' ')
            {
                Console.WriteLine("Du tapte! Press Y for å spille igjen eller N for å avslutte.");
                char response = Convert.ToChar(Console.ReadLine());
                if (response == 'Y')
                {
                    Board board = new Board();
                    ResetBoard();
                    GameConsole.Show(board);
                }

                if (response == 'N') return false;
            }
        }
        return true;
}

    private void ResetBoard()
    {
        foreach (var square in squares)
        {
            square.CurrentSquare = ' ';
        }
    }
}