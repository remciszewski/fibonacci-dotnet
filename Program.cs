using System;

class Program
{
    static void Main(string[] args)
    {
        int len = 10;
        if (args.Length > 0 && int.TryParse(args[0], out int parsedLen))
        {
            len = parsedLen;
        }
        GenerateFibonacci(len);
    }

    static void GenerateFibonacci(int len)
    {
        if (len < 1) return;

        int a = 0;
        int b = 1;
        int c;

        Console.Write("{0} {1}", a, b);
        for (int i = 2; i < len; i++)
        {
            c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}
