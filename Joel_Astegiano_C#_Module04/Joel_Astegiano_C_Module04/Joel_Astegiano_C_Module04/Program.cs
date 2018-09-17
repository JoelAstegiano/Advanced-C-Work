using System;

namespace Joel_Astegiano_C_Module04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an amount of  quarters"); // Get Quarters
            int quarters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0:C} Dollars in {1} Quarters", ConverQuartersToDollars(quarters), quarters); //Calculate Dollars

            Console.ReadKey();

            Console.WriteLine("Enter an a room width"); //Get width
            double room_width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an a room height"); //Get height
            double room_height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} Square feet is {1:C} Dollars worth of paint", squareFeet(room_width, room_height), paintPrice(1.50, squareFeet(room_width, room_height))); //At 1.50
            Console.WriteLine("{0} Square feet is {1:C} Dollars worth of paint", squareFeet(room_width, room_height), paintPrice(6.00, squareFeet(room_width, room_height))); //At 6
            Console.ReadKey();
        }
        static double ConverQuartersToDollars(int quarter) //Convert Quarters to Dollars
        {
            double dollars=Convert.ToDouble(quarter);
            return dollars / 4;
        }

        static double squareFeet(double w, double h) //Calculate Area
        {
            return w * h;
        }
        static double paintPrice(double p, double a) // Calculate Price given Area and rate
        {
            return p * a;
        }
    }
}
