using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1YavorskiV20
{
    public class OrderTerm
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public OrderTerm(Order order, Product product)
        {
            Order = order;
            Product = product;   
        }
    }
}
