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
            { model.Id = 1;
            model.Name = "Ss24ultra";
            model.UnitPrice = 70000;
            model.Category = "phone";
            model.Discount = 10;
            model.DiscountedPrice = model.UnitPrice * ((100 - model.Discount) / 100); }//data base den gelen veriler olsun bunlar
        }

        public override ProductViewModel GetProductData()
        {
            {
                model.Id = 1;
                model.Name = "Ss24ultra";
                model.UnitPrice = 70000;
                model.Category = "phone";
                model.Discount = 10;
            } return model;
            }
    }
}
