using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueberrySwap.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}