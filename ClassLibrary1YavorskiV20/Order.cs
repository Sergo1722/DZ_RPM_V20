using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1YavorskiV20
{
    public class Order
    {
        public string? DateOfReceipt { get; set; }
        public bool IsPaid { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }

        public Client? Client { get; set; }
    }
}
