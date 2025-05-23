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
        public List<Products> Read();
        public void Delete(int productid);
        public Products GetByID(int idproduct);

    }
}
