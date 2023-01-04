using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepsWork.Api.Domain.Entities;

namespace StepsWork.Api.Infra.Mappings
{
    public class ServiceMap : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("service");

            builder.HasKey(s => s.Id);

            builder
                .Property(s => s.Id)
                .HasColumnName("id");

            builder
                .Property(s => s.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder
                .Property(s => s.Date)
                .HasColumnName("date")
                .IsRequired();

            builder
                .Property(s => s.Value)
                .HasColumnName("value")
                .IsRequired();

            builder
                .Property(s => s.Evaluation)
                .HasColumnName("evaluation")
                .IsRequired();

            builder
                .Property(s => s.Observation)
                .HasColumnName("observation");


            builder
                .Property(s => s.CategoryId)
                .HasColumnName("category_id")
                .IsRequired();

            builder
                .HasOne(s => s.User)
                .WithMany(u => u.Services)
                .HasForeignKey(s => s.UserId);

            builder
                .HasOne(s => s.Category)
                .WithMany(c => c.Services)
                .HasForeignKey(s => s.CategoryId);
        }
    }
}
