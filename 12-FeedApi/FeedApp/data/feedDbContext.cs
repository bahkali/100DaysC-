using FeedApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedApp.data
{
    public class feedDbContext : DbContext
    {
        public virtual DbSet<PostModel> Posts {get; set;} 
        public feedDbContext(DbContextOptions<feedDbContext> options) : base(options)
        {
            
        }
    }
}