using ClothBazar.DataBase;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloathBazar.Services
{
   public class CategoryService
    {
        public void SaveCategory(Category category)
        {
            //Here we are creating an object to the CbContext class (ClothBazar.DataBase) 
            using (var context = new CBConttext())
            {
                //Need to add the entites into Category table.
                context.Categories.Add(category);
                //To saved the dataq in to table
                context.SaveChanges();
            }
        }
        // Here we will get list of categories so written type should be List<Category>
        public List<Category> GetCategories()
        {
            using (var context = new CBConttext())
            {
                return context.Categories.ToList();
            }
        }
//Logic to get the particular ID
        public Category GetCategory(int ID)
        {
            using (var context = new CBConttext())
            {
                return context.Categories.Find(ID);
            }
        }
        //LOgic to update the ID
        public void UpdateCategory(Category category)
        {
            using (var context = new CBConttext())
            {
                // we dont have update method in C#, so we need to tell to the EF like entities got modified.
                // Then EF will update the changes in to the Database table.
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }   


        //Loic to Deete the record
        public void DeletteCateory(int ID)
        {
            using (var context = new CBConttext())
            {
                var cateories = context.Categories.Find(ID);
                //  Below one is for delte the record in EF style
                // context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                //  Below one is for delte the record in EF-2 style
                context.Categories.Remove(cateories);
                context.SaveChanges();
            }
        }

    }
}
