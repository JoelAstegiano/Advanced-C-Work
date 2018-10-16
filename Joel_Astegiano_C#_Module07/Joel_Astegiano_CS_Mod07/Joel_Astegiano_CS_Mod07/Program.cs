using System;
using System.Timers;

namespace Joel_Astegiano_CS_Mod07
{
    public delegate string delTest(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            delTest delObj = new delTest(delMethod);
            int a = 12;
            int b = 13;
            string result = delObj(a, b);
            Sqr newsqr= new Sqr();
            newsqr.thing(2);

            Console.WriteLine("The first number is {0} than the second number", result);
            Timer myTimer = new Timer(1000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Start();

            Console.ReadKey();

        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        static string delMethod(int num1, int num2)
        {
            if (num1 >= num2)
                return "Larger";
            else
                return "smaller";

        
        }
        class Rectangle //I thought we made an example of inheritance last week...
        {
            private double length;

            private double width;

            public double GetLength() { return length; }

            public double GetWidth() { return width; }

            public void setLength(double l) { length = l; }

            public void setWidth(double w) { width = w; }

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }
            public Rectangle()
            {

            }
            public double GetArea()
            {
                return length * width;
            }

            public int thing(int a)
            {
                return a;
            }

        }

        class Sqr : Rectangle
        {
            public void setSide(double side)
            {
                setWidth(side);
                setLength(side);
            }

            public double GetSquareArea()
            {
                return Math.Pow(GetLength(), 2);
            }

            public void check()
            {
                if (GetLength() == 0.0)
                {
                    throw new ArgumentNullException();
                }
            }
        }
    }
}
