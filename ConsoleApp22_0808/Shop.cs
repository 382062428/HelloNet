using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0808
{
    class Shop
    {
        public Product[] Product { get; set; }

        public Shop(int length)
        {
            this.Product = new Product[length];
        }

        public decimal GetTotalPrice()
        {
            var totalPrice = 0m;
            if(this.Product.Length > 0)
            {
                foreach(var item in this.Product)
                {
                    totalPrice += item.Price * item.Count;
                }
            }
            Console.WriteLine($"总价为：{totalPrice}");
            return totalPrice;
        }

        public string Add(Product pro)
        {
            var msg = "很遗憾，仓库已满，无法添加新商品";
            if (this.Product.Length > 0)
            {
                for(var i = 0; i < this.Product.Length; i++)
                {
                    if(this.Product[i] == null)
                    {
                        this.Product[i] = pro;
                        msg = $"商品添加成功，新商品在第{i+1}个位置";
                        break;
                    }
                }
            }
            Console.WriteLine(msg);
            return msg;
        }
    }
}
