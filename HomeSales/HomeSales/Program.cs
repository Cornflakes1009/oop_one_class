using System;
using static System.Console;


namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double danielSales = 0;
            double edwardSales = 0;
            double francisSales = 0;
            string initialLetter = "a";
            string highestSalesman = "no one. It's a tie.";

            while(initialLetter != "z" && initialLetter != "Z")
            {
                WriteLine("Please enter an initial.");
                initialLetter = ReadLine().ToLower();

                if(initialLetter == "d" || initialLetter == "e" || initialLetter == "f")
                {
                    WriteLine("How much was the sale?");
                    double sale = Convert.ToDouble(ReadLine());

                    switch (initialLetter)
                    {
                        case "d":
                            danielSales += sale;
                            break;
                        case "e":
                            edwardSales += sale;
                            break;
                        case "f":
                            francisSales += sale;
                            break;
                        default:
                            break;
                    }
                          
                }
                else if(initialLetter == "z")
                {
                    WriteLine("Daniel's Sales: {0}", danielSales);
                    WriteLine("Edwards's Sales: {0}", edwardSales);
                    WriteLine("Francis's Sales: {0}", francisSales);
                    WriteLine("Total Sales: " + (danielSales + edwardSales + francisSales));
                    
                    if(danielSales > edwardSales && danielSales > francisSales)
                    {
                        highestSalesman = "Daniel";
                    } else if (edwardSales > danielSales && edwardSales > francisSales)
                    {
                        highestSalesman = "Edward";
                    } 
                    else if(francisSales > danielSales && francisSales > edwardSales)
                    {
                        highestSalesman = "Francis";
                    }
                    
                    WriteLine("The salesman with the highest sales is: {0}", highestSalesman);
                }
                else
                {
                    WriteLine("Invalid initial");
                }


               
            }
            ReadLine(); // added so console doesn't close upon program completion
        }
    }
}
