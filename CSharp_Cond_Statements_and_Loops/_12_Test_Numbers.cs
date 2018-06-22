using System;

class _12_Test_Numbers
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int boundary = int.Parse(Console.ReadLine());

        int combinations = 0;
        int sum = 0;
        for (int i = num1; i >= 1; i--)
        {
            for (int j = 1; j <= num2; j++)
            {
                sum += 3 * i * j;
                combinations++;
                if (sum >= boundary)
                {
                    Console.WriteLine($"{combinations} combinations\r\nSum: {sum} >= {boundary}");
                    return;
                }
            }
        }
        Console.WriteLine($"{combinations} combinations\r\nSum: {sum}");
    }
}