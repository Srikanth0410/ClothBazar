using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
   public class Category: BaseEntity
    {
        // Catteory wi have list of products.
       public List<Product> Product { get; set; }
    }
}
