using System;

class _06_Interval_of_Numbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int smallerNumber = Math.Min(a, b);
        int biggerNumber = Math.Max(a, b);

        for (int i = smallerNumber; i <= biggerNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}