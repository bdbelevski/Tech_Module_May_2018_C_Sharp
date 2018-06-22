using System;

class _02_Choose_a_Drink_2
{
    static void Main(string[] args)
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double price;

        switch (profession)
        {
            case "Athlete":
                price = 0.7;
                break;
            case "Businessman":
            case "Businesswoman":
                price = 1;
                break;
            case "SoftUni Student":
                price = 1.7;
                break;
            default:
                price = 1.2;
                break;
        }
        double orderValue = quantity * price;
        Console.WriteLine($"The {profession} has to pay {orderValue:F2}.");
    }
}
