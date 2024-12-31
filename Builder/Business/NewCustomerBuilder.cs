using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Business
{
    internal class NewCustomerBuilder : ProductBuilder//yeni müşterilere bir fırsat varsa bu classa fonksiyon yada vb olarak eklenebilir
    {
        ProductViewModel model=new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.Discount = 10;//başka şekilde gelebilir veri

            if (model.Discount > 0)
            {
                model.DiscountedPrice = model.UnitPrice * ((100 - model.Discount) / 100);
                model.DiscountApplied = true;
            }
            else
            {
                model.DiscountApplied = false;
            }

        }
        public override ProductViewModel GetProduct()
        {
            return model;
        }

        public override void GetProductData()
        {
            {
                model.Id = 1;
                model.Name = "Ss24ultra";
                model.UnitPrice = 70000;
                model.Category = "phone";
            }//data base den gelen veriler olsun bunlar

        }
    }
}
