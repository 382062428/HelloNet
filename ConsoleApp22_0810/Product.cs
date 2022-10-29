using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime Birthday { get; set; }

        public string Show()//方法的签名
        {
            return null;
        }

        public Product(int id, string name, int price, DateTime birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Birthday = birthday;
        }
    }
}
