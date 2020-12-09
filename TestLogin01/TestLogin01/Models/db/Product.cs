using System;
using System.Collections.Generic;

#nullable disable

namespace TestLogin01.Models.db
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int? SellerId { get; set; }
        public int? ProductTypeCode { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public double? ProductUnit { get; set; }
        public string ProductDescription { get; set; }

        public virtual Seller ProductNavigation { get; set; }
    }
}
