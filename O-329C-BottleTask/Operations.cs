namespace O_329C_BottleTask;

public class Operations
{
    internal static bool solutionFound = false;

    
    private static string[] operationNames = new[]
    {
        "Fill bottle 1 from the tap",
        "Fill bottle 2 from the tap",
        "Empty bottle 1 into bottle 2",
        "Empty bottle 2 into bottle 1",
        "Fill bottle 2 using bottle 1",
        "Fill bottle 1 using bottle 2",
        "Empty bottle 1",
        "Empty bottle 2",
    };
    private static void DoOperations(int[] operations, Bottle bottle1, Bottle bottle2)
    {
        //Console.WriteLine("Performing operations...");
        //Console.WriteLine($"Before operations: bottle1 = {bottle1._content}, bottle2 = {bottle2._content}");
        
        foreach (var operation in operations)
        {
            switch (operation)
            {
                case 0:
                    Console.WriteLine("Filling bottle1");
                    bottle1.FillBottle();
                    break;
                case 1: 
                    Console.WriteLine("Filling bottle2");
                    bottle2.FillBottle();
                    break;
                case 2:
                    Console.WriteLine("Emptying bottle1 into bottle2");
                    bottle1.EmptyBottleInOtherBottle(bottle2);
                    break;
                case 3:
                    Console.WriteLine("Emptying bottle2 into bottle1");
                    bottle2.EmptyBottleInOtherBottle(bottle1);
                    break;
                case 4:
                    Console.WriteLine("Filling bottle1 to bottle2");
                    bottle1.FillBottleWithOtherBottle(bottle2);
                    break;
                case 5:
                    Console.WriteLine("Filling bottle2 to bottle1");
                    bottle2.FillBottleWithOtherBottle(bottle1);
                    break;
                case 6:
                    Console.WriteLine("Emptying bottle1");
                    bottle1.EmptyBottle();
                    break;
                case 7:
                    Console.WriteLine("Emptying bottle2");
                    bottle2.EmptyBottle();
                    break;
            }
            //Console.WriteLine($"After operation {operation}: bottle1 = {bottle1._content}, bottle2 = {bottle2._content}");

        }
        //Console.WriteLine($"After all operations: bottle1 = {bottle1._content}, bottle2 = {bottle2._content}");

    }

    private static bool CheckIfSolvedAndExitApplicationIfSo(
        Bottle bottle1, Bottle bottle2, int wantedVolume, int[] operations)
    {
        if (bottle1._content == wantedVolume || bottle2._content == wantedVolume || bottle2._content + bottle1._content == wantedVolume)
        {
            Console.WriteLine($"Solution found with operations: {string.Join(", ", operations)}");
            return true;
        }

        return false;
    }
    
    private static bool UpdateOperations(int[] operations)
    {
        int i;
        for (i = operations.Length-1; i >= 0; i--)
        {
            if (operations[i] < 7)
            {
                operations[i]++;
                break;
            }
            operations[i] = 0;
        }
        return i != -1;
    }
    

    
    internal static void TryWithGivenNumberOfOperations(
        int numberOfOperations, Bottle bottle1, Bottle bottle2, int wantedVolume)
    {
        Console.WriteLine($"Trying with {numberOfOperations} operation(s).");
        var operations = new int[numberOfOperations];
        
        bottle1._content = 1;
        bottle2._content = 2;
        
        while (true)
        {
            bottle1._content = 1;
            bottle2._content = 2;
            
            Console.WriteLine($"Trying operations: {string.Join(", ", operations)}");
            DoOperations(operations, bottle1, bottle2);
            if (CheckIfSolvedAndExitApplicationIfSo(bottle1, bottle2, wantedVolume, operations))
            {
                var operationDescriptions = operations.Select(op => operationNames[op]);
                Console.WriteLine($"Solution found with: {string.Join(", ", operationDescriptions)}");
                Console.WriteLine($"Solution found with: {string.Join(", ", operations)}");
                Console.WriteLine(bottle1._content + ", " + bottle2._content);
                solutionFound = true;
                break;
            }
            if (!UpdateOperations(operations)) break; 
        }
    }
}
