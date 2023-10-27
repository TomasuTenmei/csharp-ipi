class Program
{
    static string[] MotToTab(string mot)
    {
        string[] tab = new string[mot.Length];
        for (int i = 0; i < mot.Length; i++)
        {
            tab[i] = mot[i].ToString();
        }
        return tab;
    }

    static string TabToMotInsert(string[] tab, string insert)
    {
        string mot = "";
        for (int i = 0; i < tab.Length; i++)
        {
            mot += tab[i] + insert;
        }
        mot = mot.Remove(mot.Length - 1);
        return mot;
    }

    static void Main(string[] args)
    {
        string mot = "bonjour";
        string[] tab = MotToTab(mot);
        string motInsert = TabToMotInsert(tab, ".");
        System.Console.WriteLine(motInsert);
    }
}
