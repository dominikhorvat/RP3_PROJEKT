using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    internal class Notification
    {
        public int Id {  get; set; }
        public Item Item { get; set; }
        public NotificationLocation Location { get; set; }
        public DateTime Time { get; set; }

        public override string ToString()
        {
            if(Location == NotificationLocation.STORAGE)
            {
                return $"{Time}: Potrebno naručiti artikl '{Item.Name}' (ID={Item.Id}) u skladište - trenutno stanje: {Item.StorageQuantity}!";
            } else // u hladnjaku
            {
                return $"{Time}: Potrebno nadopuniti artikl '{Item.Name}' (ID={Item.Id}) u hladnjak - trenutno stanje: {Item.FreezerQuantity}!";
            }
            
        }
    }
}
