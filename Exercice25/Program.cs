class Program
{
    static void Main(string[] args)
    {
        HashSet<int> hashSet = new HashSet<int>();

        for (int i = 0; i < 1000000; i++)
        {
            hashSet.Add(i);
        }

        List<int> list = new List<int>();

        for (int i = 0; i < 1000000; i++)
        {
            list.Add(i);
        }
        
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        sw.Start();
        System.Console.WriteLine(list.Contains(900000));
        sw.Stop();
        System.Console.WriteLine("Liste : " + sw.ElapsedMilliseconds + " ms");
        sw.Reset();

        sw.Start();
        System.Console.WriteLine(hashSet.Contains(900000));
        sw.Stop();
        System.Console.WriteLine("HashSet : " + sw.ElapsedMilliseconds + " ms");
        sw.Reset();
    }
}