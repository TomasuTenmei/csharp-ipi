class Program
{
    static void Palindrome(string mot)
    {
        string motInverse = "";

        for (int i = mot.Length - 1; i >= 0; i--)
        {
            motInverse += mot[i];
        }

        if (mot == motInverse)
        {
            System.Console.WriteLine("Le mot : {0} est un palindrome", mot);
        }
        else
        {
            System.Console.WriteLine("Le mot : {0} n'est pas un palindrome", mot);
        }
    }

    static void Main(string[] args)
    {
        string mot = "kayak";
        Palindrome(mot);

        mot = "bonjour";
        Palindrome(mot);
    }
}