using System;

namespace Module02
{
    class Program
    {
        static void Main(string[] args)
        {

            const double MILESTOKILOMETERS =1.6; //Conversion Factor

            Console.Write("Type a number of miles:"); //Get miles
            string milesText =Console.ReadLine();
            double milesNum = Convert.ToDouble(milesText);

            Console.WriteLine(milesNum + " Miles is " + milesToKilometers(milesNum, MILESTOKILOMETERS) + " Kilometers" ); //Display Result
            Console.ReadKey();

            Console.Write("Type a number of miles:"); // Get Miles
            string milesText2 = Console.ReadLine();
            double milesNum2 = Convert.ToDouble(milesText2);

            Console.Write("Type a number of days:"); //Get Days
            string daysText = Console.ReadLine();
            int daysNum = Convert.ToInt32(daysText);

            const double MILERATE = 0.25; //Rate per Mile

            Console.WriteLine("Total cost is " + totalCarCost(daysNum, milesNum2, MILERATE)); //Display Result
            Console.ReadKey();

            Console.Write("Temp in Fahrenheit: "); //Get Temp
            string tempText = Console.ReadLine();
            double tempNum = Convert.ToDouble(tempText);

            Console.WriteLine(tempNum + " F is " + toCelsius(tempNum) + " C");
            Console.ReadKey();

        }
        static double milesToKilometers(double miles, double kilofactor) //Convert
        {
            return (miles * kilofactor);

        }
        static double totalCarCost(int days, double miles, double rate) //Calculate
        {
            return ((miles *rate )+(days*20));

        }

        static double toCelsius(double fahrenheit) //Calculate
        {
            return (((5*(fahrenheit-32))/9));

        }
    }
}
