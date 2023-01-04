using Microsoft.EntityFrameworkCore;
using StepsWork.Api.Domain.Entities;
using StepsWork.Api.Infra.Mappings;

namespace StepsWork.Api.Infra
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserCategoryMap());
            modelBuilder.ApplyConfiguration(new ServiceMap());
        }
    }
}
