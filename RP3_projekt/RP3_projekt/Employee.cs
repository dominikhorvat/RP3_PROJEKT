using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP3_projekt
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username{ get; set; }
        public string Authorization { get; set; }
        public byte Coffee { get; set; }
        public byte Juice { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
