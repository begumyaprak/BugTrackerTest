using BugTrackerTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Developer> Developers{ get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Work> Works { get; set; }



    }
}