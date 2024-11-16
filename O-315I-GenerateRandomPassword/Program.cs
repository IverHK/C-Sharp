namespace O_315I_GenerateRandomPassword;

class Program
{
 static void Main(string[] args)
    {
        Console.WriteLine(args[0]);
        Console.WriteLine(args[1]);
        
        if (!IsValid(args))
        {
            Console.WriteLine(ShowHelpMessage());
            return;
        }

        int length = Convert.ToInt32(args[0]);
        string pattern = args[1];
        string password = "";

        
        while (pattern.Length < length)
        {
            pattern = pattern + "l";
        }

        while (pattern.Length > 0)
        {
            int randomIndex = Random.Shared.Next(0, pattern.Length - 1);
            char charAtIndex = pattern[randomIndex];
            pattern = pattern.Remove(randomIndex, 1);
            
            if (charAtIndex == 'l')
            {
                password += WriteRandomLowerCaseLetter();
            }
            else if (charAtIndex == 'L')
            {
                password += WriteRandomUpperCaseLetter();
            }
            else if (charAtIndex == 'd')
            {
                password += WriteRandomDigit();
            }
            else if (charAtIndex == 's')
            {
                password += WriteRandomSpecialCharacter();
            }
            else return;
                
            Console.WriteLine(password);
        }
    }
     
    static char WriteRandomLowerCaseLetter()
    {
        return GetRandomLetter('a', 'z');
    }

    static char WriteRandomUpperCaseLetter()
    {
        return GetRandomLetter('A', 'Z');
    }

    static char WriteRandomDigit()
    {
        int randomDigit = Random.Shared.Next(0, 10);

        return randomDigit.ToString()[0];
    }

    static char WriteRandomSpecialCharacter()
    {
        string spesialCharacters = "!\"#$%&/()=+*?"; 
        int randomDigit = Random.Shared.Next(0, spesialCharacters.Length);

        return spesialCharacters[randomDigit];
    }
    
    static char GetRandomLetter(char min, char max)
    {
        return (char)Random.Shared.Next(min, max);
    }

    private static bool IsValid(string[] args)
    {
        if (args.Length != 2) return false;
        
        string length = args[0];
        string code = args[1];
        int passwordLength = 0;
        
        foreach (var c in length)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        passwordLength = Convert.ToInt32(length);
        
        char[] chars = code.ToCharArray();
        foreach (var c in chars)
        {
            if ((c == 'l' || c == 'L' || c == 'd' || c == 's') && passwordLength >= 1)
            {
                continue;
            }
        }
        return true;
    }
    
    
    
    private static string ShowHelpMessage()
    {
        return "PasswordGenerator  \nOptions:\n- l = liten bokstav\n- L = stor bokstav\n- d = siffer\n- s = spesialtegn (!\"#\u00a4%&/(){}[]\nEksempel: PasswordGenerator 14 lLssdd\n    betyr\n        Min. 1 liten bokstav\n        Min. 1 1 stor bokstav\n        Min. 2 spesialtegn\n        Min. 2 sifre\n        Lengde på passordet skal være 14";
    }
}