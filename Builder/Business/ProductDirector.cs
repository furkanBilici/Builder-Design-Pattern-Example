using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Business
{
    public class ProductDirector
    {
        public void GenerateProduct(ProductBuilder product) 
        {
            product.GetProductData();
            product.ApplyDiscount();
        }
    }
}
