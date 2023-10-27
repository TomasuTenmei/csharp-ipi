class Program
{
    static void Somme(int nombre)
    {
        var somme = 0;
        for (var i = 0; i <= nombre; i++)
        {
            somme += i;
        }
        Console.WriteLine($"La somme des entiers de 1 à {nombre} est {somme}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Entrez un nombre :");
        var nombre = Console.ReadLine();
        try
        {
            Somme(int.Parse(nombre));
        }
        catch
        {
            Console.WriteLine("Erreur : la valeur entrée n'est pas un nombre.");
        }
    }
}