using System;
using static System.Console;

namespace TipCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the cost of the meal.");
            double mealCost = Convert.ToDouble(ReadLine());

            WriteLine("What is the percentage of tip being left?");
            double tipLeft = Convert.ToDouble(ReadLine());
            // overloaded method that accepts a meal price as a double and a tip % as a double

            // display the meal price, tip in percentage of the meal price, tip in dollars, and total of meal plus tip

            // overloaded method that accepts a meal price as an int and a tip as an int
            mealCost = Convert.ToInt32(mealCost);
            tipLeft = Convert.ToInt32(tipLeft);
            CalculateTip(mealCost, tipLeft);


            ReadLine();
        }

        public static void CalculateTip(int tip, int meal)
        {
            WriteLine("Meal total: ${0}. The tip was ${1}. The tip was {2}", tip + meal, tip, (tip / meal) * 100);
            Console.WriteLine("some text");
        }

        public static void CalculateTip(Double FN, Double SN)
        {
            
        }

            
    }
    
}
