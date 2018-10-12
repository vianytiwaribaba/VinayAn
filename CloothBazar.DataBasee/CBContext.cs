using CloothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloothBazar.DataBasee
{
    public class CBContext :DbContext
    {
        public CBContext() :base("WebAnuvConnection")
        {

        }
        public DbSet<Category> categories { get; set;}

        public DbSet<Product> products { get; set; }
    }
}
