using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepsWork.Api.Domain.Entities;

namespace StepsWork.Api.Infra.Mappings
{
    public class UserMap: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.HasKey(u => u.Id);

            builder
                .Property(uc => uc.Id)
                .HasColumnName("id");

            builder
                .Property(u => u.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(128)")
                .IsRequired();

            builder
                .Property(u => u.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(128)")
                .IsRequired();

            builder
                .Property(u => u.Password)
                .HasColumnName("password")
                .HasColumnType("varchar(128)")
                .IsRequired();

            builder
               .Property(u => u.Phone)
               .HasColumnName("phone")
               .HasColumnType("decimal(11,0)");

            builder
               .Property(u => u.WhatsApp)
               .HasColumnName("whats_app")
               .IsRequired();

            builder
                .Property(u => u.Photo)
                .HasColumnName("photo")
                .HasColumnType("varchar(512)");

            builder
                .Property(u => u.Street)
                .HasColumnName("street")
                .HasColumnType("varchar(128)");

            builder
                .Property(u => u.Number)
                .HasColumnName("number");

            builder
                .Property(u => u.District)
                .HasColumnName("district")
                .HasColumnType("varchar(128)");

            builder
                .Property(u => u.City)
                .HasColumnName("city")
                .HasColumnType("varchar(128)");

            builder
                .Property(u => u.State)
                .HasColumnName("state")
                .HasColumnType("varchar(2)");

            builder
                .Property(u => u.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();

            builder
                .Property(u => u.UpdatedAt)
                .HasColumnName("updated_at");
        }
    }
}
