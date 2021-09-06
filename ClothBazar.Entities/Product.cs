using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
   public class Product: BaseEntity
    {
        public decimal price { get; set; }
       // one product belons to one particular category like Men Category or Woman Category::
        public Category Category { get; set; }
      
    }

}
