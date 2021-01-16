using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMarket.Entity.Concrete;

namespace EMarket.DataAccess.Concrete.EntityFramework.Contexts
{
    public class EMarketContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
