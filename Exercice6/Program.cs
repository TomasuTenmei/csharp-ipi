class Program
{
    static string etatFeu = "vert";

    static void Feu()
    {
        if (etatFeu == "vert")
        {
            etatFeu = "orange";
        }
        else if (etatFeu == "orange")
        {
            etatFeu = "rouge";
        }
        else if (etatFeu == "rouge")
        {
            etatFeu = "vert";
        }
    }

    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            Feu();
            Console.WriteLine(etatFeu);
        }
    }
}
