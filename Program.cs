using System;
using System.Diagnostics;
internal class Program
{
    public static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 100000; i++)
        {
            Console.WriteLine(i);
        }
        stopwatch.Stop();
        Console.WriteLine(Stopwatch.GetTimestamp());
    }
}