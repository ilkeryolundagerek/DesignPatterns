using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class SingleResponsibility
    {
    }

    //Bad way...
    public class ProductModelBad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void AddToCart()
        {
            //...
        }
    }

    //Good way...
    public class ProductModelGood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class CartService
    {
        public void AddToCart(ProductModelGood product)
        {
            //...
        }
    }
}
