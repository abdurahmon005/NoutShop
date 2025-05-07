using NoutShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoutShop.Services.Interfaces
{
     interface IProductService
    {
        public string Create(Products products);
        public IEnumerable<Products> GetAll();
         public Products Update(Products products);
        public Products UpdateproductPrice(Products product);
        public bool Delete(int idproduct);
        public Products GetByID(int idproduct);

    }
}
