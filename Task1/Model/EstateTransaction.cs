using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum PropertyType
    {
        Condo,
        MultiFamily,
        Residential

    }
    public class EstateTransaction
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public int SqFeet { get; set; }
        public PropertyType Type { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Price { get; set; }

    }
}
