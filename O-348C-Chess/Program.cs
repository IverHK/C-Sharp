using System.Text;

namespace O_348C_Chess;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        var board = new Board();
        // var bishop = new Piece("Bishop", "LPR");
        // var rook = new Piece("Rook", "TRN");
        var bishop = new Bishop("\u2657");
        var rook = new Rook("\u265c");
        
        board.Set("e4", bishop);
        board.Set("f7", rook);
        while (true)
        {
            board.Show();
            Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
            var positionFrom = Ask("Hvilken rute vil du flytte fra?");
            var positionTo = Ask("Hvilken rute vil du flytte til?");
            board.Move(positionFrom, positionTo);
        }

        string Ask(string question)
        {
            Console.Write(question);
            Console.Write(" ");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
            return answer;
        }    }
}