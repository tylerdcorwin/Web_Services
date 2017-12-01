using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week8lab.Models
{
    public class Item
    {
        public String PartNo { get; set; }
        public String Description { get; set; }
        public String UnitPrice { get; set; }
        public String Quantity { get; set; }
        public String TotalCost { get; set; }
        public String Size { get; set; }
        public String Color { get; set; }
    }
}