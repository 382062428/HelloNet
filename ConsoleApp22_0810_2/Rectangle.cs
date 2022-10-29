using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810_2
{
    class Rectangle:Graphic
    {
        public Rectangle(int length, double width, double height) : base(length)
        {
            base.BianChang = new double[length];
            base.BianChang[0] = width;
            base.BianChang[1] = height;
        }

        public override double GetLength()
        {
            return (base.BianChang[0] + base.BianChang[1]) * 2;
            //return base.GenLength();
        }

        public override double GetArea()
        {
            return base.BianChang[0] * base.BianChang[1];
            //return base.GetArea();
        }

        public new void AA()
        {
            Console.WriteLine($"矩形的AA");
            //base.AA();
        }
    }
}
