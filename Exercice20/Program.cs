class Program
{
    static int[] FusionTabInsertIn(int[] tab1, int[] tab2, int pos)
    {
        int[] tab = new int[tab1.Length + tab2.Length];
        int i = 0, j = 0, k = 0;

        while (i < pos)
        {
            tab[k] = tab1[i];
            i++;
            k++;
        }

        while (j < tab2.Length)
        {
            tab[k] = tab2[j];
            j++;
            k++;
        }

        while (i < tab1.Length)
        {
            tab[k] = tab1[i];
            i++;
            k++;
        }

        return tab;
    
    }

    static void Main(string[] args)
    {
        int[] tab1 = new int[] { 1, 3, 5, 7, 9 };
        int[] tab2 = new int[] { 2, 4, 6, 8, 10, 11, 12, 13 };
        Console.WriteLine("Tableau 1 : " + string.Join(", ", tab1));
        Console.WriteLine("Tableau 2 : " + string.Join(", ", tab2));
        Console.WriteLine("Tableau fusion : " + string.Join(", ", FusionTabInsertIn(tab1, tab2, 3)));
    }
}