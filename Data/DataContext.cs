using Kavita.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kavita.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<AppUser> Users { get; set; }
    }
    
    
}