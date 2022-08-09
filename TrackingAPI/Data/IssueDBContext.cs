using Microsoft.EntityFrameworkCore;
using TrackingAPI.Models;

namespace TrackingAPI.Data
{
    public class IssueDBContext : DbContext
    {
        public IssueDBContext(DbContextOptions<IssueDBContext> options) : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }

    }
}
