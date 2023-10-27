class Program
{
    static void DivisionSuccessive(double nombre)
    {
        int nbDivisions = 0;
        while(nombre > 1)
        {
            nombre /= 2;
            nbDivisions++;
        }
        Console.WriteLine($"Nombre de divisions: {nbDivisions}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Entrez un nombre: ");
        string input = Console.ReadLine();
        int nombre = int.Parse(input);
        DivisionSuccessive(nombre);
    }
}