using Microsoft.EntityFrameworkCore;
using StepsWork.Api.Domain.Entities;
using StepsWork.Api.Infra.Mappings;

namespace StepsWork.Api.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
