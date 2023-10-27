class Program
{
    static void OrdreCroissant(string a, string b, string c)
    {
        var nombres = new List<string>();
        nombres.Add(a);
        nombres.Add(b);
        nombres.Add(c);
        nombres.Sort();
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }

    static void Main(string[] args)
    {
        string a, b, c;
        try
        {
            Console.WriteLine("Entrez 3 caractères :");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Erreur : les valeurs entrées ne sont pas des caractères.");
            return;
        }

        OrdreCroissant(a, b, c);
    }
}