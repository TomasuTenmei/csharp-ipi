class Program
{
    static (int, int, int) Aleatoire()
    {
        var random = new Random();
        var nombre1 = random.Next(1, 100);
        var nombre2 = random.Next(1, 100);
        var nombre3 = random.Next(1, 100);
        return (nombre1, nombre2, nombre3);
    }

    static void Decroissant(List<int> nombres)
    {
        nombres.Sort();
        nombres.Reverse();
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Entrez 3 nombre :");
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        var c = Console.ReadLine();

        try
        {
            var nombres = new List<int>();
            nombres.Add(int.Parse(a));
            nombres.Add(int.Parse(b));
            nombres.Add(int.Parse(c));
            nombres.Add(Aleatoire().Item1);
            nombres.Add(Aleatoire().Item2);
            nombres.Add(Aleatoire().Item3);
            Decroissant(nombres);
        }
        catch
        {
            Console.WriteLine("Erreur : les valeurs entrées ne sont pas des nombres.");
        }

    }
}