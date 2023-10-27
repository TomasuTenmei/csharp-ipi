class Program
{
    static void Multiple(int nombre)
    {
        for (var i = 0; i <= 20; i++)
        {
            Console.WriteLine($"{nombre} x {i} = {nombre * i}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Entrez un nombre :");
        var nombre = Console.ReadLine();
        try
        {
            Multiple(int.Parse(nombre));
        }
        catch
        {
            Console.WriteLine("Erreur : la valeur entrée n'est pas un nombre.");
        }
    }
}