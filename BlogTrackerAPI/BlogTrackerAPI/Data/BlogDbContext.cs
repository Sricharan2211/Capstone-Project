using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogTrackerAPI.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogTrackerAPI.Models.BlogInfo> BlogInfo { get; set; } = default!;

        public DbSet<BlogTrackerAPI.Models.EmpInfo>? EmpInfo { get; set; }
        public DbSet<BlogTrackerAPI.Models.AdminInfo> AdminInfo { get; set; }
    }
}
