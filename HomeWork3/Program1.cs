using System;

namespace HomeWork3
{
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public bool isRectangle()
        {
            return length != width && length > 0 && width > 0;
        }
        virtual public void getArea()
        {
            if (this.isRectangle())
            {
                Console.WriteLine(length * width);
            }
            else
            {
                Console.WriteLine("You can't calculate the area, because it isn't a rectangle.");
            }  
        }
    }

    class Square:Rectangle
    {
        public Square(double side):base(side, side){}
        public bool isSquare()
        {
            return base.length == base.width && base.length > 0 && base.width > 0;
        }
        public override void getArea()
        {
            if (this.isSquare())
            {
                Console.WriteLine(base.length * base.width);
            }
            else
            {
                Console.WriteLine("You can't calculate the area, because it isn't a square.");
            } 
        }
    }

    class Triangle
    {
        private double firstside;
        private double secondside;
        private double thirdside;
        public Triangle(double firstside, double secondside, double thirdside)
        {
            this.firstside = firstside;
            this.secondside = secondside;
            this.thirdside = thirdside;
        }
        public bool isTriangle()
        {
            return firstside + secondside > thirdside && firstside + thirdside > secondside && secondside + thirdside > firstside && 
            firstside - secondside < thirdside && firstside - thirdside < secondside && secondside - thirdside < firstside &&
            firstside > 0 && secondside > 0 && thirdside > 0;
        }
        public void getArea()
        {
            double p;
            p = (firstside + secondside + thirdside) / 2;
            if (this.isTriangle())
            {
                Console.WriteLine(Math.Sqrt(Math.Sqrt(p*((p - firstside) * (p - secondside) * (p - thirdside)))));
            }
            else
            {
                Console.WriteLine("You can't calculate the area, because it isn't a triangle.");
            } 
        }
    }
    class Program1
    {
        void Main(string[] args)
        {

        }
    }
}
