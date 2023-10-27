class Program
{
    static void WaterCondition(float temperature)
    {
        if (temperature < 0)
        {
            Console.WriteLine("L'eau est à l'état solide.");
        }
        else if (temperature >= 0 && temperature < 100)
        {
            Console.WriteLine("L'eau est à l'état liquide.");
        }
        else
        {
            Console.WriteLine("L'eau est à l'état gazeux.");
        }
    }

    static void Main(string[] args)
    {
        WaterCondition(-10);
        WaterCondition(20);
        WaterCondition(120);
    }
}