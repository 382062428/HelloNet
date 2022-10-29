using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0808
{
    enum ProductType
    {
        数码,手机,零食,化妆品,服装
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public DateTime BirthDay { get; set; }
        public int Count { get; set; }

        //无参构造方法
        public Product()
        {
            Id = 1;
            Name = "iPhone 12";
            Price = 8888;
            Type = ProductType.手机;
            BirthDay = new DateTime(2011,1,1);
            Count = 1000;
        }

        //有参构造函数
        public Product(int id, string name, decimal price, ProductType type, DateTime birthday, int count)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Type = type;
            this.BirthDay = birthday;
            this.Count = count;
        }

        ~Product()
        {
            Console.WriteLine("对象即将被销毁......");
        }
    }
}
