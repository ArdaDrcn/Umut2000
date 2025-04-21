using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using Umut2000.Entity.Models;

namespace Umut2000.DataAccess.Context
{
    public class UmutContext : DbContext
    {
        public UmutContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<UmutUser> UmutUsers { get; set; }
        public  DbSet<Mission> Missions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UmutUser>().ToCollection("UmutUsers");
            modelBuilder.Entity<Mission>().ToCollection("Missions");
        }
    }
}
