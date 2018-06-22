using System;

class _08_Calories_Counter
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string ingredient;
        int calories = 0;
        for (int i = 0; i < n; i++)
        {
            ingredient = Console.ReadLine().ToLower();
            if (ingredient == "tomato sauce")
            {
                calories += 150;
            }
            if (ingredient == "cheese")
            {
                calories += 500;
            }
            if (ingredient == "salami")
            {
                calories += 600;
            }
            if (ingredient == "pepper")
            {
                calories += 50;
            }
        }
        Console.WriteLine($"Total calories: {calories}");
    }
}