using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810
{
    public class MyClass
    {
        public void Change(int value = 5)
        {
            Console.WriteLine($"参数为：{value}");
        }

        //out参数的使用背景：当方法需要返回多个值（有可能类型不同）
        //从商品数组中，根据id获取商品的名称、价格、生产日期
        public void GetProductInfo(Product[] product, int id, out string name, out int price, out DateTime birthday)
        {
            name = "";
            price = 0;
            birthday = DateTime.Now;

            foreach(var pro in product)
            {
                if(pro.Id == id)
                {
                    name = pro.Name;
                    price = pro.Price;
                    birthday = pro.Birthday;
                    break;
                }
            }
        }

        //params参数：参数数量不确定
        public int Function(params int[] nums)
        {
            var sum = 0;
            if(nums.Length > 0)
            {
                foreach(var item in nums)
                {
                    sum += item;
                }
            }
            Console.WriteLine($"sum为：{sum}");
            return sum;
        }

        //ref传地址
        public void Change(ref int a, ref int b)
        {
            var c = 0;
            c = a;
            a = b;
            b = c;
        }
    }
}
