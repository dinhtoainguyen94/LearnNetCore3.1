using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Price { get; set; }
        public string OriginalPrice { get; set; }
        public string Stock { get; set; }
        public string VewCount { get; set; }
        public string DateCreated { get; set; }
        public string SeoAlias { get; set; }

    }
}
