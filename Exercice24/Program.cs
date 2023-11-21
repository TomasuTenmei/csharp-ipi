class Program
{
    static void inverseListe(List<string> liste)
    {
        List<string> listeInverse = new List<string>();

        for (int i = liste.Count - 1; i >= 0; i--)
        {
            listeInverse.Add(liste[i]);
        }

        System.Console.WriteLine("\nListe inversée :");

        for (int i = 0; i < listeInverse.Count; i++)
        {
            System.Console.WriteLine(listeInverse[i]);
        }
    }

    static void printListe(List<string> liste)
    {
        System.Console.WriteLine("\nListe des noms :");

        for (int i = 0; i < liste.Count; i++)
        {
            System.Console.WriteLine(liste[i]);
        }
    }

    static void Main(string[] args)
    {
        var name = "";
        List<string> nameList = new List<string>();

        while (true)
        {
            System.Console.Write("Entrez un nom n° " + (nameList.Count + 1) + " : ");
            name = Console.ReadLine();

            if (int.TryParse(name, out int n))
            {
                if (nameList.Count <= 5)
                {
                    System.Console.WriteLine("Vous ne pouvez pas quittez le programme avant d'avoir entré 6 noms.");
                }
                else
                {
                    break;
                }
                
            }
            else
            {
                nameList.Add(name);
            }

        }

        printListe(nameList);

        nameList.RemoveAt(1);
        nameList.RemoveAt(3);
        nameList[2] = "Toto";

        printListe(nameList);

        inverseListe(nameList);
    }
}