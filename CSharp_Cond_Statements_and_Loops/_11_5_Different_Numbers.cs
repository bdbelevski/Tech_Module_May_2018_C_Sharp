using System;

class _11_5_Different_Numbers
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int combinations = 0;

        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                for (int k = start; k <= end; k++)
                {
                    for (int m = start; m <= end; m++)
                    {
                        for (int p = start; p <= end; p++)
                        {
                            bool isValid = (start <= i) && (i < j) && (j < k) && (k < m) && (m < p) && (p <= end);
                            if (isValid)
                            {
                                Console.WriteLine($"{i} {j} {k} {m} {p}");
                                combinations++;
                            }
                        }
                    }
                }
            }
        }
        if (combinations == 0)
        {
            Console.WriteLine("No");
        }
    }
}