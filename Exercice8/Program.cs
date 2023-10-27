class Program
{
    static void Addition(int a, int b)
    {
        try
        {
            var result = a + b;
            Console.WriteLine(result);
        }
        catch
        {
            Console.WriteLine("Erreur : les valeurs entrées ne sont pas des nombres.");
        }

    }

    static void DivisionEuclidienne(int a, int b)
    {
        try
        {
            var quotient = a / b;
            var reste = a % b;
            Console.WriteLine($"{a} / {b} = {quotient}, Reste : {reste}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erreur : division par zéro.");
        }
        catch
        {
            Console.WriteLine("Erreur : les valeurs entrées ne sont pas des nombres.");
        }

    }

    static void Calcul()
    {
        Console.WriteLine("Entrez deux nombres :");
        var a = Console.ReadLine();
        var b = Console.ReadLine();

        Console.WriteLine("Addition :");
        Addition(int.Parse(a), int.Parse(b));
        Console.WriteLine("Division Euclidienne :");
        DivisionEuclidienne(int.Parse(a), int.Parse(b));

    }

    static void Main(string[] args)
    {
        Calcul();
    }
}