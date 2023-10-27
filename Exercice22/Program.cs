class Program
{
    static string DeleteString(string mot, string caractere)
    {
        string motSansCaractere = "";
        for (int i = 0; i < mot.Length; i++)
        {
            if (mot[i].ToString() != caractere)
            {
                motSansCaractere += mot[i];
            }
        }
        return motSansCaractere;
    }

    static void Main(string[] args)
    {
        string mot = "b#on##j#o#u#r##";
        string motSansCaractere = DeleteString(mot, "#");
        System.Console.WriteLine(motSansCaractere);
    }
}