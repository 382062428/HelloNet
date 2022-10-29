using System;

namespace ConsoleApp22_0808
{
    enum Gender
    {
        男,女
    }

    enum Color
    {
        红,橙,黄,绿,青,蓝,紫
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 枚举类，属于值类型
            //Console.WriteLine($"当前选择的性别是：{Gender.男}");
            #endregion

            #region 类的实例化，创建对象
            //Show方法的重载
            //var show = new ShowClass();
            //show.Show();
            //show.Show("一路畅通");
            //show.Show(10, 10);

            //添加商品案例
            var shop = new Shop(5);
            var p1 = new Product(1, "苹果1", 1000, ProductType.手机, new DateTime(2011, 1, 1), 10);
            var p2 = new Product(2, "苹果2", 2000, ProductType.手机, new DateTime(2012, 1, 1), 10);
            var p3 = new Product(3, "苹果3", 3000, ProductType.手机, new DateTime(2013, 1, 1), 10);
            var p4 = new Product(4, "苹果4", 4000, ProductType.手机, new DateTime(2014, 1, 1), 10);
            var p5 = new Product(5, "苹果5", 5000, ProductType.手机, new DateTime(2015, 1, 1), 10);
            var p6 = new Product(6, "苹果6", 6000, ProductType.手机, new DateTime(2016, 1, 1), 10);

            shop.Add(p1);
            shop.Add(p2);
            shop.Add(p3);
            shop.Add(p4);
            shop.Add(p5);
            shop.Add(p6);
            shop.GetTotalPrice();
            #endregion
        }
    }
}
