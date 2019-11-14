using System;
using static System.Console;

namespace InchesToCentmeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Please enter a value in inches: ");
            double inches = Convert.ToDouble(ReadLine());
            WriteLine(inches + " inches is " + (inches * 2.54) + " centimeters");
            int someMoney = 5;
            WriteLine("The money is ${0}", someMoney);
            int var1 = 3;
            WriteLine(4 + 2 * 3);
            int var2 = var1++;
            double hourly = 13.0;
            WriteLine(hourly);
            double salary = 45000.00;
            WriteLine(salary.ToString("c"));
            WriteLine(salary.ToString("c0"));
        }
    }
}
