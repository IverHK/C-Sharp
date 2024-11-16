namespace O_315A;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        var number = random.Next(1, 10);
        GuessNumber(number);  
    }

    static void GuessNumber(int number)
    {
        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("Guess the secret number, it's between 1 and 10: ");
            var input = Console.ReadLine();
                
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
                continue;
            }
            if (guess < number)
            {
                Console.WriteLine("The secret number is greater than the guessed number! Guess again: ");
            }
            else if (guess > number)
            {
                Console.WriteLine("The secret number is less than the guessed number! Guess again: ");
            }
        }
        Console.WriteLine("Congratulations! You guessed the secret number!");
    }
}