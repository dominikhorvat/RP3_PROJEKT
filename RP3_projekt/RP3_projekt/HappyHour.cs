using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    internal class HappyHour
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public decimal Discount { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeUntil { get; set; }
    }
}
