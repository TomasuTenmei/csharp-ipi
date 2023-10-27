class Program
{
    static List<int> TabToIndex(List<int> tab)
    {
        List<int> tabToIndex = new List<int>();

        for (int i = 0; i < tab.Count; i++)
        {
            tabToIndex.Add(i);
        }

        return tabToIndex;
    }

    static void Main(string[] args)
    {
        List<int> tab = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        Console.WriteLine("Tableau initial : " + string.Join(", ", tab));
        Console.WriteLine("Tableau d'index : " + string.Join(", ", TabToIndex(tab)));
    }
}