using System;
using System.Collections.Generic;

#nullable disable

namespace TestLogin01.Models.db
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public string LoginPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public byte[] Picture { get; set; }
    }
}
