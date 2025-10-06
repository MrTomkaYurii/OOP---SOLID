using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___SOLID.S.SRPGoodExample
{
    // 1. Модель даних - відповідає лише за структуру даних
    public class Order
    {
        public string Id { get; set; }
        public string CustomerEmail { get; set; }
        public List<string> Items { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice => TotalPrice - Discount;
        public DateTime CreatedAt { get; set; }
    }
}
