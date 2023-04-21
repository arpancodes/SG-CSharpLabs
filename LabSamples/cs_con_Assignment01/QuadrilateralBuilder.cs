using cs_con_Assignment01.Demo01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assignment01
{
    enum SymbolTypes
    {
        Rectangle,
        Square
    }

    internal class QuadrilateralBuilder
    {

        public Demo01.Quadrilateral? GetQuadrilateral(
            SymbolTypes symboltype, params int[] args)
        {
            Demo01.Quadrilateral? objReturn = null;
            switch (symboltype)
            {
                case SymbolTypes.Rectangle:
                    if (args.Length == 2)
                    {
                        int length = args[0];
                        int breadth = args[1];
                        objReturn = new Demo01.Rectangle(length, breadth);
                    }
                    break;
                case SymbolTypes.Square:
                    if (args.Length == 1)
                    {
                        objReturn = new Demo01.Square(args[0]);
                    }
                    break;
                default:
                    break;
            }

            return objReturn;
        }

    }
}
