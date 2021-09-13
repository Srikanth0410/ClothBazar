using ClothBazar.DataBase;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloathBazar.Services
{
   public class ProductService
    {

        //Logic to get the particular Product ID
        public Product GetProduct(int ID)
        {
            using (var context = new CBConttext())
            {
                return context.Products.Find(ID);
            }
        }

        // Here we will get list of categories so written type should be List<Product>
        public List<Product> GetProducts()
        {
            using (var context = new CBConttext())
            {
                return context.Products.ToList();
            }
        }

        public void SaveProduct(Product product)
        {
            //Here we are creating an object to the CbContext class (ClothBazar.DataBase) 
            using (var context = new CBConttext())
            {
                //Need to add the entites into Product table.
                context.Products.Add(product);
                //To saved the dataq in to table
                context.SaveChanges();
            }
        }
       
       
        //LOgic to update the ID
        public void UpdateProduct(Product product)
        {
            using (var context = new CBConttext())
            {
                // we dont have update method in C#, so we need to tell to the EF like entities got modified.
                // Then EF will update the changes in to the Database table.
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }   


        //Loic to Deete the record
        public void Deleteproduct(int ID)
        {
            using (var context = new CBConttext())
            {
                var product = context.Products.Find(ID);
                //  Below one is for delte the record in EF style
                // context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                //  Below one is for delte the record in EF-2 style
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

    }
}
