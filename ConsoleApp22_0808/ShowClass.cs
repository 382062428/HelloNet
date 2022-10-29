using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0808
{
    class ShowClass
    {
        public void Show()
        {
            Console.WriteLine("Hello i am Show");
        }

        public void Show(string msg)
        {
            Console.WriteLine($"您有新的消息：{msg}");
        }

        public void Show(int width, int height)
        {
            int length = (width + height) * 2;
            Console.WriteLine($"周长为：{length}");
        }
    }
}
