using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepsWork.Api.Domain.Entities;

namespace StepsWork.Api.Infra.Mappings
{
    public class UserCategoryMap : IEntityTypeConfiguration<UserCategory>
    {
        public void Configure(EntityTypeBuilder<UserCategory> builder)
        {
            builder.ToTable("user_category");

            builder.HasKey(uc => uc.Id);

            builder
                .Property(uc => uc.Id)
                .HasColumnName("id");

            builder
                .Property(uc => uc.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder
                .Property(uc => uc.CategoryId)
                .HasColumnName("category_id")
                .IsRequired();

            builder
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserCategories)
                .HasForeignKey(uc => uc.UserId);

            builder
                .HasOne(uc => uc.Category)
                .WithMany(c => c.UserCategories)
                .HasForeignKey(uc => uc.CategoryId);
        }
    }
}
