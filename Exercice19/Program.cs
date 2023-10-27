class Program
{
    static int[] FusionTabInsert(int[] tab1, int[] tab2)
    {
        int[] tabFusion = new int[tab1.Length + tab2.Length];
        int i = 0, j = 0, k = 0;

        while (i < tab1.Length && j < tab2.Length)
        {
            if (tab1[i] < tab2[j])
            {
                tabFusion[k] = tab1[i];
                i++;
            }
            else
            {
                tabFusion[k] = tab2[j];
                j++;
            }
            
            k++;
        }

        while (i < tab1.Length)
        {
            tabFusion[k] = tab1[i];
            i++;
            k++;
        }

        while (j < tab2.Length)
        {
            tabFusion[k] = tab2[j];
            j++;
            k++;
        }

        return tabFusion;
    }

    static void Main(string[] args)
    {
        int[] tab1 = new int[] { 1, 3, 5, 7, 9 };
        int[] tab2 = new int[] { 2, 4, 6, 8, 10, 11, 12, 13 };
        Console.WriteLine("Tableau 1 : " + string.Join(", ", tab1));
        Console.WriteLine("Tableau 2 : " + string.Join(", ", tab2));
        Console.WriteLine("Tableau fusion : " + string.Join(", ", FusionTabInsert(tab1, tab2)));
    }
}