internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> A = new HashSet<int>();
        HashSet<int> B = new HashSet<int>();
        HashSet<int> C = new HashSet<int>();

        Console.Write("How many students for course A? ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            A.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("How many students for course B? ");
        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            A.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("How many students for course C? ");
        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            A.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> D = new HashSet<int>(A);
        D.UnionWith(B);
        D.UnionWith(C);

        Console.WriteLine("Total students: " + D.Count);
    }
}