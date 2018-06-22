using System;

class _04_Hotel_2
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPrice = 0;
        double doublePrice = 0;
        double suitePrice = 0;

        if (month == "May" || month == "October")
        {
            studioPrice = 50 * nights;
            doublePrice = 65 * nights;
            suitePrice = 75 * nights;
            if (nights > 7)
            {
                studioPrice *= 0.95;
                if (month == "October")
                {
                    studioPrice = (studioPrice / nights) * (nights - 1);
                }
            }
        }
        else if (month == "June" || month == "September")
        {
            studioPrice = 60 * nights;
            doublePrice = 72 * nights;
            suitePrice = 82 * nights;
            if (nights > 14)
            {
                doublePrice *= 0.9;
            }
            if (nights > 7 && month == "September")
            {
                studioPrice = (studioPrice / nights) * (nights - 1);
            }
        }
        else if (month == "July" || month == "August" || month == "December")
        {
            studioPrice = 68 * nights;
            doublePrice = 77 * nights;
            suitePrice = 89 * nights;
            if (nights > 14)
            {
                suitePrice *= 0.85;
            }
        }
        Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        Console.WriteLine($"Double: {doublePrice:f2} lv.");
        Console.WriteLine($"Suite: {suitePrice:f2} lv.");
    }
}