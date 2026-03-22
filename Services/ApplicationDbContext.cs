using Final_Project_E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_E_Commerce.Services
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
