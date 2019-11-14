using System;
using static System.Console;

class DailyTemps
{
    static void Main()
    {
        int temp = 0;
        int total = 0;
        int average = 0;
        int tempCount = 0;
        int sentinelValue = 999;

        while (temp != sentinelValue)
        {
            WriteLine("Please enter a number valid temperature ranging from -20 to 130");
            temp = Convert.ToInt32(ReadLine());

            if(temp >= -20 && temp <= 130)
            {
                tempCount++;
                total += temp;
            }
            else if(temp == sentinelValue)
            {
                average = total / tempCount;
                WriteLine("The total average temperature is {0}, with a combined total of {1} for all temperatures. {2} temperatures were entered.", average, total, tempCount);
            }
            else
            {
                WriteLine("Invalid temperature. Temperature must be between -20 and 130.");
            }
        }

        ReadLine(); // added so the console doesn't close and can see the outcome.
    }
}