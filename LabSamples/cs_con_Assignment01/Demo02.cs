using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assignment01.Demo02
{
    interface IGeometricSymbols         // interface IShape
    {
        decimal Perimeter { get;  }
    }

    interface ISquare : IGeometricSymbols
    {
        int Side { get; }
        decimal Area();
    }

    interface IRectangle : IGeometricSymbols
    {
        int Length { get; }
        int Breadth { get;  }
        decimal Area();
    }

    interface Circle : IGeometricSymbols
    {
        int Radius { get; }
    }

    class Quadrilateral : IRectangle, ISquare
    {
        enum QuadrilateralType
        {
            Rectangle,
            Square;
        }

        private int side1, side2, side3, side4;
        private QuadrilateralType typeOfShape;

        public Quadrilateral(int side)
        {
            this.side1 = this.side2 = this.side3 = this.side4 = side;
            this.typeOfShape = QuadrilateralType.Square;
        }

        public Quadrilateral(int length, int breadth)
        {
            this.side1 = this.side3 = length;
            this.side2 = this.side4 = breadth;
            this.typeOfShape = QuadrilateralType.Rectangle;
        }

        int IRectangle.Length
        {
            get { 
                if(this.typeOfShape != QuadrilateralType.Rectangle)
                {
                    throw new Exception("Current object is not a Rectangle!");
                }
                return this.side1; 
            }
        }

        int IRectangle.Breadth
        {
            get { return this.side2; }
        }

        int ISquare.Side
        {
            get { return this.side1;  }
        }

        public decimal Perimeter
        {
            get { return this.side1 + this.side2 + this.side3 + this.side4; }
        }

        decimal ISquare.Area()
        {
            int side = (this as ISquare).Side;
            return side * side;
        }

        decimal IRectangle.Area()
        {
            int l = (this as IRectangle).Length;
            int b = (this as IRectangle).Breadth;
            return l * b;
        }
    }

}
