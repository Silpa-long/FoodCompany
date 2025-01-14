using FoodCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodCompany.Repository
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
 

        public DbSet<MenuItem> MenuItem { get; set; }
       
     

    }
}
