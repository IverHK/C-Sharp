namespace O_341A_Stars;

class Program
{      
    static void Main(string[] args)
    {
        var random = new Random();
        IAllStars[] stars = new IAllStars[]
        {
            new PhasesStar(random),
            new PhasesStar(random),
            new PhasesStar(random),
            new MovableStar(random),
            new MovableStar(random),
            new MovableStar(random),
        };
        while (true)
        {
            Console.Clear();     
            
            foreach (var star in stars)
            {
                star.Show();
                star.Update();
            }
            
            
            // foreach (var star in stars)
            // {
            //     if (star is PhasesStar)
            //     {
            //         var phasesStar = (PhasesStar)star;
            //         phasesStar.Show();
            //         phasesStar.Update();
            //     }
            //     else if (star is MovableStar)
            //     {
            //         var phasesStar = (MovableStar)star;
            //         phasesStar.Show();
            //         phasesStar.Update();
            //     }
            // }
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Thread.Sleep(200);
        }
    }
}