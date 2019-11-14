using System;
using static System.Console;

namespace FineForOverdueBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfOverdueBooks = 0;
            double daysOverdue = 0;
            double lessThanEightDayCost = .10;
            double greaterThanSeveDayCost = .20;
            double balanceDue = 0;

            // ask how many books are checked out
            WriteLine("How many overdue books do you have?");
            // getting the number of books checked out
            numOfOverdueBooks = Convert.ToDouble(ReadLine());
        
            // ask how many days they're overdue
            WriteLine("How many days overdue are they?");
            // getting the number of days the books are overdue.
            daysOverdue = Convert.ToDouble(ReadLine());
             void calculateLateFees(Double numOfBooks, Double days)
            {
                if(days > 7)
                {
                    // calculating higher cost for days after 7 and later
                    balanceDue += ((days % 7) * (greaterThanSeveDayCost * numOfBooks));
                    balanceDue += (7 * (lessThanEightDayCost * numOfBooks));
                } else
                {
                    balanceDue += (days * lessThanEightDayCost * numOfBooks);
                }
               
            }

            calculateLateFees(numOfOverdueBooks, daysOverdue);
            WriteLine("${0} is due for {1} overdue book(s).", balanceDue, numOfOverdueBooks);
            ReadLine(); // added for keeping console open so I can read it. 
        }
    }
}
