using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormHW5
{
    public class FakeRepo
    {
        public static List<Product> GetProducts()
        {
            return new()
            { 
                new Product("Cola",2.00),
                new Product("Fanta",3.00),
                new Product("Snickers",1.50),
                new Product("Bounty",4.00),
                new Product("Chudo",1.40),
                new Product("Chocolate",3.00),
                new Product("Sprite",1.00),
                new Product("Bread",0.60),
                
            };


        }
    }
}
