using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    internal class Item
    {
        public int Id { get; set; }
        public ItemCategory Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int FreezerQuantity { get; set; }
        public int StorageQuantity { get; set; }
        public int SelectedQuantity { get; set; } = 0;
        public byte FreeCount { get; set; } = 0;

        public override string ToString()
        {
            return Name;
        }

        public Item Clone()
        {
            return new Item
            {
                Id = this.Id,
                Category = this.Category,
                Name = this.Name,
                Price = this.Price,
                FreezerQuantity = this.FreezerQuantity,
                StorageQuantity = this.StorageQuantity,
                SelectedQuantity = this.SelectedQuantity,
                FreeCount = this.FreeCount,
            };
        }
    }
}
