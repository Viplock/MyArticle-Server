﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyArticle.Data;

namespace MyArticle.Data.Migrations
{
    [DbContext(typeof(ArticleDbContext))]
    partial class ArticleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyArticle.Core.Article", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiniView")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("WritterId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WritterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Article");
                });
#pragma warning restore 612, 618
        }
    }
}
