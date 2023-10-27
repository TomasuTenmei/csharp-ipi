static void Main(string[] args)
{
    Calcul();
}

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

    Console.WriteLine("Addition :");
    Addition(int.Parse(a), int.Parse(b));
    Console.WriteLine("Division Euclidienne :");
    DivisionEuclidienne(int.Parse(a), int.Parse(b));

}

Main(args);