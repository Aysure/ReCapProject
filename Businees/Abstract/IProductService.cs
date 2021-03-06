﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businees.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetByBrandId(int brandId);


    }
}
