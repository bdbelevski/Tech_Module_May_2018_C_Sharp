using System;

class _06_Interval_of_Numbers_2
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        {
            Console.WriteLine(i);
        }
    }
}