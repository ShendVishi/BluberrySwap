using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueberrySwap.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int ItemId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}