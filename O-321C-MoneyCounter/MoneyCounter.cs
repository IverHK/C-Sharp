namespace O_321C_MoneyCounter;

class MoneyCounter
{
    private int _value;
    private int _count;
    
    internal MoneyCounter(int value, int count)
    {
        _value = value;
        _count = count;
    }

    internal static void Total(MoneyCounter[] wallet)
    {
        int totalAmount = 0;
    
        foreach (var coin in wallet)
        {
            totalAmount += coin._value * coin._count;
        }
        Console.WriteLine($"Total Amount: {totalAmount}");
    }
} 