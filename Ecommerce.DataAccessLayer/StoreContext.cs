using Ecoomerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccessLayer
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}