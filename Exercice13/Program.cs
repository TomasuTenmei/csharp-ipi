class Program
{
    static void Multiple(int nombre)
    {
        List<string> nombres = new List<string>();
        for (var i = 0; i <= 30; i++)
        {
            nombres.Add((i + 1) * nombre + "");
        }
        string result = string.Join(" | ", nombres);
        Console.WriteLine(result);
    }

    static void Main(string[] args)
    {
        Multiple(3);
    }
}