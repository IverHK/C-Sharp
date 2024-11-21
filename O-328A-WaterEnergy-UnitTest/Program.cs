namespace O_328A_WaterEnergy_UnitTest;

class Program
{
    static void Main(string[] args)
    {
        var water = new Water(10, 70);
        water.AddEnergy(6400);
    }
}