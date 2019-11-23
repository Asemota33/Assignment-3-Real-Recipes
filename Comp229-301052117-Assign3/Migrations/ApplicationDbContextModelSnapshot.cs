﻿// <auto-generated />
using Comp229_301052117_Assign3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Comp229_301052117_Assign3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Comp229_301052117_Assign3.Models.Ingredients", b =>
                {
                    b.Property<string>("IngredientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("RecipesID");

                    b.Property<string>("Size");

                    b.HasKey("IngredientID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Comp229_301052117_Assign3.Models.Recipes", b =>
                {
                    b.Property<int>("RecipesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("DishName")
                        .IsRequired();

                    b.Property<string>("Instructions")
                        .IsRequired();

                    b.Property<string>("Servings")
                        .IsRequired();

                    b.Property<string>("ingredients1");

                    b.Property<string>("ingredients2");

                    b.Property<string>("ingredients3");

                    b.Property<string>("review");

                    b.HasKey("RecipesID");

                    b.ToTable("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
