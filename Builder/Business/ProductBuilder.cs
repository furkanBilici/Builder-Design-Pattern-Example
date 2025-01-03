﻿using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Business
{
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();//daha farklı değerler döndürebilir
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetProduct();
    }
}
