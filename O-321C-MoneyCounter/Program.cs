namespace O_321C_MoneyCounter;

class Program
{
    static void Main(string[] args)
    {
        MoneyCounter[] wallet = new MoneyCounter[4];
        wallet[0] = new MoneyCounter(1, 7);
        wallet[1] = new MoneyCounter(5, 3);
        wallet[2] = new MoneyCounter(10, 2);
        wallet[3] = new MoneyCounter(20, 11);
        
        MoneyCounter.Total(wallet);

    }
}