using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Joel_Astegiano_CS_Module08
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetSide(11, 10);
            Console.WriteLine(rect.GetArea());
            rect.readOut();
            Sqr sqr = new Sqr();
            sqr.SetSide(11, 10);
            sqr.SetSide(11, 11);
            Console.WriteLine(sqr.GetArea());
            sqr.SetSide(11);
            Console.WriteLine(sqr.GetArea());
            Console.ReadKey();

        }

        interface rectMethods {
            void readOut();
        }

        abstract class Shape
        {
            public abstract void SetSide(double a, double b);
        }

        class Rectangle:Shape, rectMethods
        {
            private double length;

            private double width;

            public double GetLength() { return length; }

            public double GetWidth() { return width; }

            public void setLength(double l) { length = l; }

            public void setWidth(double w) { width = w; }

            public void readOut()
            {
                Console.WriteLine("Length: {0}\nWidth: {1}", length, width);
            }
            
            public virtual double GetArea()
            {
                return length * width;
            }

            public override void SetSide(double Length, double Width)
            {
                length = Length;
                width = Width;
            }

            
            
        }

        class Sqr : Rectangle //Feel like I've seen this before, but I have given it a abstract overide and an interface reference
        {
            
            public double SqrSide { get; set; }
            public void SetSide(double side)
            {
                SqrSide = side;
            }

            public override double GetArea()
            {
                return Math.Pow(SqrSide, 2);
            }

            public override void SetSide(double Length, double Width)
            {
                if (Length == Width)
                {
                    SqrSide = Length;
                }
                else
                {
                    Console.WriteLine("Please use the same lenght and width for a square or use one value to set all sides.");
                }
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
