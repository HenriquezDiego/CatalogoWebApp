﻿// <auto-generated />
using System;
using CatalogoWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatalogoWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201124212315_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CatalogoWebApp.Models.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorId");

                    b.HasIndex("CarreraId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.Carrera", b =>
                {
                    b.Property<int>("CarreraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarreraId");

                    b.HasIndex("FacultadId");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.Facultad", b =>
                {
                    b.Property<int>("FacultadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultadId");

                    b.ToTable("Facultades");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.Tipo", b =>
                {
                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoId");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.TrabajoDeGraduacion", b =>
                {
                    b.Property<int>("TrabajoDeGraduacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("PathImagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrabajoDeGraduacionId");

                    b.HasIndex("AutorId");

                    b.HasIndex("TipoId");

                    b.ToTable("TrabajosDeGraduacion");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.Autor", b =>
                {
                    b.HasOne("CatalogoWebApp.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.Carrera", b =>
                {
                    b.HasOne("CatalogoWebApp.Models.Facultad", "Facultad")
                        .WithMany("Carreras")
                        .HasForeignKey("FacultadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facultad");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.TrabajoDeGraduacion", b =>
                {
                    b.HasOne("CatalogoWebApp.Models.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoWebApp.Models.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("CatalogoWebApp.Models.Facultad", b =>
                {
                    b.Navigation("Carreras");
                });
#pragma warning restore 612, 618
        }
    }
}
