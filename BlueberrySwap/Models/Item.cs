using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueberrySwap.Models
{
    public class Item
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public Double Price { get; set; }
        public int Status { get; set; } // 1-available, 0-not available
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; } // author
    }
}