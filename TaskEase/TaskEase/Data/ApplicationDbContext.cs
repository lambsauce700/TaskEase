using Microsoft.EntityFrameworkCore;
using TaskEase.Models.Domain;

namespace TaskEase.Data
{
    public class ApplicationDbContext : DbContext
    {
        


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

            
        }
        public DbSet<User> Users { get; set; }
    }
}
