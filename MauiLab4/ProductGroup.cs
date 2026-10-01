using System;
using System.Collections.Generic;
using System.Text;

namespace MauiLab4
{
    public class ProductGroup : List<Product>
    {
        public string GroupName { get; set; }
        public ProductGroup(string groupName, List<Product> products) : base(products)
        {
            GroupName = groupName;
        }
    }
}
