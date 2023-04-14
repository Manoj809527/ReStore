using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        //Where DbSet effectively represents tables in a database
        public DbSet<Product> Products { get; set; }
    }
}