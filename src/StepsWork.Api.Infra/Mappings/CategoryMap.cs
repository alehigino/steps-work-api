using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepsWork.Api.Domain.Entities;

namespace StepsWork.Api.Infra.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("category");

            builder.HasKey(c => c.Id);

            builder
                .Property(uc => uc.Id)
                .HasColumnName("id");

            builder
                .Property(u => u.Description)
                .HasColumnName("description")
                .HasColumnType("varchar(64)")
                .IsRequired();
        }
    }
}
