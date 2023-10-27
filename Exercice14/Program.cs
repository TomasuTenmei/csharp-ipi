class Program
{
    static void Suite()
    {
        int nombre = 0;

        while (nombre < 22)
        {
            if (nombre < 3)
            {
                Console.WriteLine(nombre);
            }
            else if (nombre % 3 == 0)
            {
                Console.WriteLine(nombre);
            }

            nombre++;
        }
    }

    static void Main(string[] args)
    {
        Suite();
    }
}