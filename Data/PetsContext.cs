using Microsoft.EntityFrameworkCore;
using Pets.Api.Models;

namespace Pets.Api.Data
{
    public class PetsContext : DbContext
    {
        public PetsContext(DbContextOptions<PetsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}