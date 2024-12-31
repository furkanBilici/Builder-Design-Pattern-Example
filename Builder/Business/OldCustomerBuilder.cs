using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Business
{
    internal class OldCustomerBuilder : ProductBuilder
    {
        public override void ApplyDiscount(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public override ProductViewModel GetProductData()
        {
            throw new NotImplementedException();
        }
    }
}
