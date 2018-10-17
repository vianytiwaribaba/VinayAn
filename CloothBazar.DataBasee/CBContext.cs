using CloothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloothBazar.DataBasee
{
    public class CBContext :DbContext,IDisposable
    {
        public CBContext() :base("WebAnuvConnection")
        {

        }
        public DbSet<Category> Products { get; set;}

        public DbSet<Product> Product { get; set; }
        public object Categories { get; set; }
    }
}
