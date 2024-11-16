namespace O;

class Program
{
    private static void Main(string[] args)
    {
        
        var nameinput = AskQuestionString("Hello, What is you name? ");
        Console.WriteLine($"Hello, {nameinput}!");
        
        var ageInput = AskQuestionInt("What is your birthyear? ");
        var hadBirthday = AskQuestionBool("Have you had birthday this year? ");
        var age = 2024 - Convert.ToInt32(ageInput);
        if (!hadBirthday) age--;
        Console.WriteLine($"you are, {age}");
    }

    public static string AskQuestionString(string question)
    {
        Console.Write($"{question}: ");
        return Console.ReadLine();
    }    
    
    public static string AskQuestionInt(string question)
    {
        var birthYear = AskQuestionString(question);
        return birthYear;
    }
    
    public static bool AskQuestionBool(string question)
    {
        var answer = AskQuestionString(question + " (y/n)");
        return answer.ToLower().StartsWith("j");
    }
}