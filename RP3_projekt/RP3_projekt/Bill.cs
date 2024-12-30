using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    internal class Bill
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public Employee Employee { get; set; }
        public List<Item> Items { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public List<Discount> Discounts { get; set; }
    }
}
