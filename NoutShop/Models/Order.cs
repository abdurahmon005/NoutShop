using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoutShop.Models
{
      class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string OrderName { get; set; }
        public string CategoryOrder {  get; set; }
        public DateTime OrderTime { get; set; } = DateTime.UtcNow; 
       
    }
}
