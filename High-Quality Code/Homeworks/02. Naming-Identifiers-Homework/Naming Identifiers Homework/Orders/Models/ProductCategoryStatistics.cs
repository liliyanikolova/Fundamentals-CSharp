using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Models
{
    public class ProductCategoryStatistics
    {
        public string CategoryName { get; set; }

        public int ProductCount { get; set; }

        public decimal TotalQuantity { get; set; }
    }
}
