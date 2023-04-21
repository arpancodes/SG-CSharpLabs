using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assignment01.Demo01
{
    abstract class GeometricSymbols
    {
        abstract public decimal Perimeter { get; }

        abstract public decimal Area();
    }

    abstract class Quadrilateral : GeometricSymbols
    {
        protected int side1, side2, side3, side4;

        override public decimal Perimeter
        {
            get 
            { 
                return this.side1 + this.side2 + this.side3 + this.side4; 
            }
        }
    }

    class Square : Quadrilateral
    {
        public Square(int side)
        {
            base.side1 = base.side2 = base.side3 = base.side4 = side;
        }

        public int Side
        {
            get { return base.side1; }
        }

        override public decimal Area()
        {
            return this.Side * this.Side;
        }

        public override string ToString()
        {
            return $"SQUARE with side = {this.Side}";
        }
    }

    class Rectangle : Quadrilateral
    {
        public Rectangle(int length, int breadth) 
        {
            base.side1 = base.side3 = length;
            base.side2 = base.side4 = breadth;
        }

        public int Length
        {
            get { return base.side1; }
        }

        public int Breadth
        {
            get { return base.side2; }
        }

        public override decimal Area()
        {
            return this.Length * this.Breadth;
        }

        public override string ToString()
        {
            return $"RECTANGLE with length = {this.Length} and breadth = {this.Breadth}";
        }
    }

    abstract class RoundSymbols : GeometricSymbols
    {
    }

    class Circle : RoundSymbols
    {
        const decimal PI = 22 / 7;

        public int Radius { get; private set; }

        public override decimal Perimeter
        {
            get
            {
                return 2 * PI * this.Radius;
            }
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override decimal Area()
        {
            return PI * this.Radius * this.Radius;
        }
    }

}
