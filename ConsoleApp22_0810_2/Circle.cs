using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810_2
{
    public class Circle
    {
        public Circle()
        {
            Console.WriteLine("实例构造函数...");
        }

        static Circle()
        {
            Console.WriteLine("静态构造函数...");
        }

        public static void Function()
        {

        }
    }
}
