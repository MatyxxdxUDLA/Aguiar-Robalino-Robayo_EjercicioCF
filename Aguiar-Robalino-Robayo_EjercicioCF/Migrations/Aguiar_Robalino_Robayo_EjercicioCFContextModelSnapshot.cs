﻿// <auto-generated />
using System;
using Aguiar_Robalino_Robayo_EjercicioCF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aguiar_Robalino_Robayo_EjercicioCF.Migrations
{
    [DbContext(typeof(Aguiar_Robalino_Robayo_EjercicioCFContext))]
    partial class Aguiar_Robalino_Robayo_EjercicioCFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aguiar_Robalino_Robayo_EjercicioCF.Models.Estudiante", b =>
                {
                    b.Property<int>("IdBanner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBanner"));

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecintoVacunacionId")
                        .HasColumnType("int");

                    b.Property<int>("VacunaId")
                        .HasColumnType("int");

                    b.HasKey("IdBanner");

                    b.HasIndex("RecintoVacunacionId");

                    b.HasIndex("VacunaId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("Aguiar_Robalino_Robayo_EjercicioCF.Models.RecintoVacunacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaVacuna")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RecintoVacunacion");
                });

            modelBuilder.Entity("Aguiar_Robalino_Robayo_EjercicioCF.Models.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisProcedencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacuna");
                });

            modelBuilder.Entity("Aguiar_Robalino_Robayo_EjercicioCF.Models.Estudiante", b =>
                {
                    b.HasOne("Aguiar_Robalino_Robayo_EjercicioCF.Models.RecintoVacunacion", "RecintoVacunacion")
                        .WithMany()
                        .HasForeignKey("RecintoVacunacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aguiar_Robalino_Robayo_EjercicioCF.Models.Vacuna", "Vacuna")
                        .WithMany()
                        .HasForeignKey("VacunaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecintoVacunacion");

                    b.Navigation("Vacuna");
                });
#pragma warning restore 612, 618
        }
    }
}
