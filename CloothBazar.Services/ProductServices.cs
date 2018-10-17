using CloothBazar.DataBasee;
using CloothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloothBazar.Services
{
    public class ProductServices
    {
        public Product GetProduct(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Product.Find(ID);
            }
        }
        public List<Product> GetProduct()
        {
            using(var context = new CBContext())
            {
                return context.Product.ToList();
            }
        }
        public void SaveProduct(Product product)
        {
            using(var context = new CBContext())
            {
                context.Product.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            using(var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int ID)
        {
            using (var context = new CBContext())
            {
                var product = context.Product.Find(ID);
                context.Product.Remove(product);

                context.SaveChanges();
            }
        }
    }
}
