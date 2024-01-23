﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebSpasial.EfCore;

#nullable disable

namespace WebSpasial.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    partial class EF_DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebSpasial.EfCore.Tempat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("alamat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("jenis_tempat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nama_pemilik")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nama_tempat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("tempat");
                });
#pragma warning restore 612, 618
        }
    }
}
