using NoutShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoutShop.Services.Interfaces
{
    interface IOrderService
    {
        public string Create(Order order);
        public IEnumerable<Order> GetAll(); 
        public Order  Update(Order order);
        public bool Delete(Order order);
        public Order GetById(int id);


        
    }
}
