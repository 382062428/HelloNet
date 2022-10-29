using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810
{
    class GoodBigStudent:BigStudent
    {
        public void Fun()
        {
            //此处可以访问到父父类的protected属性，说明类具有传递性
            base.aa = 100;
        }
    }
}
