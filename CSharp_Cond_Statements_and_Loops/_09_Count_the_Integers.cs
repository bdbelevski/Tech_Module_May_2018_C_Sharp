using System;

class _09_Count_the_Integers
{
    static void Main(string[] args)
    {
        int count = 0;
        try
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                count++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"{count}");
        }
    }
}