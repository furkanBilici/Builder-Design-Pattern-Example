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
        public override void ApplyDiscount()
        {
            throw new NotImplementedException();
        }

        public override ProductViewModel GetProduct()
        {
            throw new NotImplementedException();
        }

        public override void GetProductData()
        {
            throw new NotImplementedException();
        }
    }
}
