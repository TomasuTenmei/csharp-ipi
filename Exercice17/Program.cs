class Program
{
    static List<int> tableau(int a, int b)
    {
        List<int> tab = new List<int>();

        for (int i = a; i <= b; i++)
        {
            tab.Add(i);
        }

        return tab;
    }

    static void Main(string[] args)
    {
        List<int> tab = tableau(5, 13);

        tab[2] = 111;

        foreach (int i in tab)
        {
            Console.WriteLine(i);
        }
    }
}