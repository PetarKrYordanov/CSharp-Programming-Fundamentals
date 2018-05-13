using System;

namespace Problem_8._Calories_Counter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int numOfIngredients = int.Parse(Console.ReadLine());
            var totalCalories = 0;

            for (int i = 0; i < numOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    totalCalories += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (ingredient == "salami")
                {
                    totalCalories += 600;
                }
                else if (ingredient == "pepper")
                {
                    totalCalories += 50;
                }

            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
