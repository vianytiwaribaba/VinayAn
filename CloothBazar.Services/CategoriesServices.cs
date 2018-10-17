using CloothBazar.DataBasee;
using CloothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloothBazar.Services
{
    public class CategoriesServices
    {
        public Category GetCategory(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Products.Find(ID);
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new CBContext())
            {
                return context.Products.ToList();
            }
        }

        public void SaveCategory (Category category)
        {
            using (var context = new CBContext())
            {
                context.Products.Add(category);

                context.SaveChanges();
            }
        }
        
        public void UpdateCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void DelectCategory(int ID)
        {   
            using (var context = new CBContext())
            {
                var category = context.Products.Find(ID);
                context.Products.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
