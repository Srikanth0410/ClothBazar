using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.DataBase
{
   public class CBConttext:DbContext
    {
        public CBConttext() : base("CothBazarConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
      public DbSet<Category> Categories { get; set; }
    }
}
