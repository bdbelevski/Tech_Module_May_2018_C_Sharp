using System;

class _13_Game_of_Numbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicalNumber = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = m; i >= n; i--)
        {
            for (int j = m; j >= n; j--)
            {
                if (i + j == magicalNumber)
                {
                    Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");
                    return;
                }
                count++;
            }
        }
        Console.WriteLine($"{count} combinations - neither equals {magicalNumber}");
    }
}