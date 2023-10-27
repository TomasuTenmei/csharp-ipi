class Program
{
    static void Addition(int a, int b)
    {
        var result = a + b;
        Console.WriteLine(result);
    }

    static void DivisionEuclidienne(int a, int b)
    {
        var quotient = a / b;
        var reste = a % b;
        Console.WriteLine($"{a} / {b} = {quotient}, Reste : {reste}");
    }

    static void Calcul()
    {
        Console.WriteLine("Entrez deux nombres :");
        var a = Console.ReadLine();
        var b = Console.ReadLine();

        if (a != "" && b != "")
        {
            Console.WriteLine("Addition :");
            Addition(int.Parse(a), int.Parse(b));

            if (b == "0")
            {
                Console.WriteLine("Division par 0 impossible");
                return;
            }
            else
            {
                Console.WriteLine("Division Euclidienne :");
                DivisionEuclidienne(int.Parse(a), int.Parse(b));
            }
        }
        else
        {
            Console.WriteLine("La valeur entrée n'est pas un nombre");
        }
    }

    static void Main(string[] args)
    {
        Calcul();
    }
}
