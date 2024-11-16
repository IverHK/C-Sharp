namespace O_323C_ThreeInARowGame;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        GameConsole.Show(board);
        while (true)
        {
            GameConsole.Show(board);
            if (!board.IsGameFinished()) break;
            board.IsGameFinished();
            Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"A2\"): ");
            string position = Console.ReadLine();
            board.Mark(position);
            Thread.Sleep(1000);
            board.MarkRandom(false);
        }
        Console.WriteLine("Takk for kampen!");
    }
}
