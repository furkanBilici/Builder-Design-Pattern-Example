using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Model
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }
        public float DiscountedPrice { get; set; }
        public string Category { get; set; }
        public int Discount { get; set; }
        public bool DiscountApplied { get; set; }
    }
}
