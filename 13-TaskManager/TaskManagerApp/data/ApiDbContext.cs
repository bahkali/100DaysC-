using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;

namespace TaskManagerApp.data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<TaskModel> tasks { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> opt) : base(opt)
        {
            
        }
    }
}