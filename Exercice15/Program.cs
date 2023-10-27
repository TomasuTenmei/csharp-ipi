class Program
{
    static void Somme(List<int> nombres)
    {
        int somme = 0;

        foreach (int nombre in nombres)
        {
            somme += nombre;
        }

        Console.WriteLine($"Somme: {somme}");
    }

    static void Main(string[] args)
    {
        List<int> nombres = new List<int>();

        while (true)
        {
            try
            {
                Console.WriteLine("Entrez un nombre: ");
                string input = Console.ReadLine();
                nombres.Add(int.Parse(input));
            }
            catch (Exception)
            {
                break;
            }
        }

        Somme(nombres);
    }
}