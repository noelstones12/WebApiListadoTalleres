﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiListadoTalleres;

#nullable disable

namespace WebApiListadoTalleres.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiListadoTalleres.Entidades.Agendamiento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("TallerId")
                        .HasColumnType("int");

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("TallerId");

                    b.ToTable("DbAgendamientos");
                });

            modelBuilder.Entity("WebApiListadoTalleres.Entidades.Taller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Taller")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DbTalleres");
                });

            modelBuilder.Entity("WebApiListadoTalleres.Entidades.Agendamiento", b =>
                {
                    b.HasOne("WebApiListadoTalleres.Entidades.Taller", "Taller")
                        .WithMany("Agendamientos")
                        .HasForeignKey("TallerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taller");
                });

            modelBuilder.Entity("WebApiListadoTalleres.Entidades.Taller", b =>
                {
                    b.Navigation("Agendamientos");
                });
#pragma warning restore 612, 618
        }
    }
}
