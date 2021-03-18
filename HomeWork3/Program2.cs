using System;

namespace HomeWork3
{
    public interface Shape
    {
        double getArea();
        bool isShape();
    }
    public class IRectangle:Shape
    {
        protected double length;
        protected double width;
        public IRectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public virtual bool isShape()
        {
            return length != width && length > 0 && width > 0;
        }
        public double getArea()
        {
            if (this.isShape())
            {
                return length * width;
            }
            else
            {
                Console.WriteLine("You can't calculate the area, because it isn't a rectangle.");
                return 0.0;
            }
        }
    }
    public class ISquare:IRectangle, Shape
    {
        public ISquare(double side):base(side, side){}
        public override bool isShape()
        {
            return base.length == base.width && base.length > 0 && base.width > 0;
        }
        double Shape.getArea()
        {
            if (this.isShape())
            {
                return base.length * base.width;
            }
            else
            {
                Console.WriteLine("You can't calculate the area, because it isn't a square.");
                return 0.0;
            }
        }
    }
    public class ITriangle:Shape
    {
        private double firstside;
        private double secondside;
        private double thirdside;
        public ITriangle(double firstside, double secondside, double thirdside)
        {
            this.firstside = firstside;
            this.secondside = secondside;
            this.thirdside = thirdside;
        }
        public bool isShape()
        {
            return firstside + secondside > thirdside && firstside + thirdside > secondside && secondside + thirdside > firstside && 
            firstside - secondside < thirdside && firstside - thirdside < secondside && secondside - thirdside < firstside &&
            firstside > 0 && secondside > 0 && thirdside > 0;
        }
        public double getArea()
        {
            double p;
            p = (firstside + secondside + thirdside) / 2;
            if (this.isShape())
            {
                return Math.Sqrt(p*((p - firstside) * (p - secondside) * (p - thirdside)));
            }
            else
            {
                Console.WriteLine("You can't calculate the area, because it isn't a triangle.");
                return 0.0;
            } 
        }
    }
    public class Factory
    {
        public static Shape createShape(int which)
        {
            Shape shape = null;
            Random ran = new Random();
            switch (which)
            {
                case 1:
                    double length = ran.Next(10, 1000) / 10.0;
                    double width = ran.Next(10, 1000) / 10.0;
                    shape = new IRectangle(length, width);
                    break;
                case 2:
                    double side = ran.Next(10, 1000) / 10.0;
                    shape = new ISquare(side);
                    break;
                default:
                    double firstside = ran.Next(10, 1000) / 10.0;
                    double secondside = ran.Next(10, 1000) / 10.0;
                    double thirdside = ran.Next(10, 1000) / 10.0;
                    shape = new ITriangle(firstside, secondside, thirdside);
                    break;
            }
            return shape;
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Shape[] shape = new Shape[10];
            for (int i = 0; i < 10; i++)
            {
                shape[i] = Factory.createShape(ran.Next(1, 4));
            }

            double sum = 0.0;
            for (int i = 0; i < 10; i++)
            {
                double mid = shape[i].getArea();
                if (mid != 0.0)
                {
                    sum += mid;
                }
                else
                {
                    Console.WriteLine($"Shape{i} is not a shape, so we change it's shape area into 0.");
                }
            }
            Console.WriteLine($"The total of the sum is {sum}.");
        }
    }
}
