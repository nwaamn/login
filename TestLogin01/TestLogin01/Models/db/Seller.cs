using System;
using System.Collections.Generic;

#nullable disable

namespace TestLogin01.Models.db
{
    public partial class Seller
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string EmailAddress { get; set; }
        public string LoginPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public byte[] Picture { get; set; }

        public virtual Product Product { get; set; }
    }
}
