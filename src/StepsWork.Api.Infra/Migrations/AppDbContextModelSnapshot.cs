﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StepsWork.Api.Infra;

namespace StepsWork.Api.Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("Evaluation")
                        .HasColumnType("int")
                        .HasColumnName("evaluation");

                    b.Property<string>("Observation")
                        .HasColumnType("longtext")
                        .HasColumnName("observation");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("service");
                });

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .HasColumnType("varchar(128)")
                        .HasColumnName("city");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("District")
                        .HasColumnType("varchar(128)")
                        .HasColumnName("district");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasColumnName("name");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("number");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasColumnName("password");

                    b.Property<decimal>("Phone")
                        .HasColumnType("decimal(11,0)")
                        .HasColumnName("phone");

                    b.Property<string>("Photo")
                        .HasColumnType("varchar(512)")
                        .HasColumnName("photo");

                    b.Property<string>("State")
                        .HasColumnType("varchar(2)")
                        .HasColumnName("state");

                    b.Property<string>("Street")
                        .HasColumnType("varchar(128)")
                        .HasColumnName("street");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<bool>("WhatsApp")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("whats_app");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.UserCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("user_category");
                });

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.Service", b =>
                {
                    b.HasOne("StepsWork.Api.Domain.Entities.Category", "Category")
                        .WithMany("Services")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StepsWork.Api.Domain.Entities.User", "User")
                        .WithMany("Services")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.UserCategory", b =>
                {
                    b.HasOne("StepsWork.Api.Domain.Entities.Category", "Category")
                        .WithMany("UserCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StepsWork.Api.Domain.Entities.User", "User")
                        .WithMany("UserCategories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.Category", b =>
                {
                    b.Navigation("Services");

                    b.Navigation("UserCategories");
                });

            modelBuilder.Entity("StepsWork.Api.Domain.Entities.User", b =>
                {
                    b.Navigation("Services");

                    b.Navigation("UserCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
