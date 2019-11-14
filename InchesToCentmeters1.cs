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
        }
    }
}
