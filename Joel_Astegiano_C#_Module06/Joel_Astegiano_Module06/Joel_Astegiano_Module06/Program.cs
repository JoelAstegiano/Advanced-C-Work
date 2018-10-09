using System;

namespace Joel_Astegiano_Module06
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle.hello(); // And a Method Call Example
            int[] count =new int[] {1, 2, 3, 4, 5 }; // An Example of an array.
            Rectangle r1 = new Rectangle(20.3, 5.4); //New Rectangle
            Console.WriteLine(r1.GetArea());
            Sqr s1 = new Sqr(); //New Square
            try //Here is a Try Catch to see if it has been assigned
            {
                s1.check();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            s1.setSide(5.0); //Set side from Square
            Console.WriteLine(s1.GetArea()); //Show Area by Rectangle
            Console.WriteLine(s1.GetSquareArea()); //Show Area by Square
            int i = 2;

                switch (i) //Switch Example
                {
                    case 1:
                        Console.WriteLine("1");
                        break;

                    case 2:
                        Console.WriteLine("1");
                        break;

                    default:
                        break;
                }

            Console.ReadKey();
            Console.WriteLine(Factorial(5));
            Console.ReadKey();
        }
        public static int Factorial(int n) //This  is a recursive method
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
    class Rectangle
    {
        private double length;
      
         private double width;

        public double GetLength() {return length; }

        public double GetWidth() { return width; }

        public void setLength(double l) { length=l; }

        public void setWidth(double w) { width=w; }

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

        public static void hello() //I suppose this is an example of a method, though it is in a class.
        {
            Console.WriteLine("Hello");
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
