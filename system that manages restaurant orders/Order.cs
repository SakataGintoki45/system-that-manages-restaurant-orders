using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_that_manages_restaurant_orders
{
    internal class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Order()
        {
            Id= 0;
            Description = "";
        }

        public override string ToString() => $"Order {Id}: {Description}";
    }
}
