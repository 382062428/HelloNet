using System;

namespace ConsoleApp22_0810
{
    class Program
    {
        static void Main(string[] args)
        {
            //可缺省参数
            //var mc = new MyClass();
            //mc.Change(100);


            //out 参数示例
            //var mc = new MyClass();
            //var name = "";
            //var price = 0;
            //var birthday = DateTime.Now;

            //var p1 = new Product(1, "AAA", 100, new DateTime(1991, 1, 2));
            //var p2 = new Product(2, "BBB", 200, new DateTime(1992, 1, 2));
            //var p3 = new Product(3, "CCC", 300, new DateTime(1993, 1, 2));
            //Product[] pro = { p1, p2, p3 };

            //Console.WriteLine($"请输入您要查找的商品编号：");
            //var id = Convert.ToInt32(Console.ReadLine());

            //mc.GetProductInfo(pro, 2, out name, out price, out birthday);

            //Console.WriteLine($"商品名称：{name}\n价格：{price}\n生产日期：{birthday}");


            //params 示例
            //var mc = new MyClass();
            //mc.Function(1,2,3,4,5);


            //ref 示例
            //int a = 10;
            //int b = 20;
            //var mc = new MyClass();
            //mc.Change(ref a, ref b);
            //Console.WriteLine($"a={a},b={b}");


            var a = new BigStudent(1, "小明", "男", "深圳大学", "手机贴膜", "羽毛球协会");
            Console.WriteLine($"id：{a.Id}");
            Console.WriteLine($"姓名：{a.Name}");
            Console.WriteLine($"性别：{a.Sex}");
            Console.WriteLine($"大学：{a.School}");
            Console.WriteLine($"专业：{a.Major}");
            Console.WriteLine($"社团：{a.Group}");

            var b = new Student();
            //b.aa 访问不了protected的aa







        }
    }
}
