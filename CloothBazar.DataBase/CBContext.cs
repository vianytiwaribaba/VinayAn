using System.Data.Entity;
using CloothBazar.Entities;

namespace CloothBazar.DataBase
{
    public  class CBContext :DbContext
    {
        public CBContext() : base("WebAnuvConnection")
        {

        }
        public DbSet<category> Categories { get; set; }

        public DbSet<Product> products { get; set; }

       

    }

    public class category
    {
    }
}
