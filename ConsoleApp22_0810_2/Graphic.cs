using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810_2
{
    public class Graphic
    {
        public double[] BianChang { get; set; }

        //
        public virtual double GetLength()
        {
            return 0;
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public Graphic(int length)
        {
            //BianChang = new double[length];
        }

        public virtual void AA()
        {
            Console.WriteLine($"图形的AA");
        }
    }
}
