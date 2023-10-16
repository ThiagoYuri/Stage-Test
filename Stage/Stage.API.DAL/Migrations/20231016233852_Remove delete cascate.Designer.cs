﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stage.API.DAL;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231016233852_Remove delete cascate")]
    partial class Removedeletecascate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AreaEmpresa", b =>
                {
                    b.Property<int>("PK_Area")
                        .HasColumnType("int");

                    b.Property<int>("PK_Empresa")
                        .HasColumnType("int");

                    b.HasKey("PK_Area", "PK_Empresa");

                    b.HasIndex("PK_Empresa");

                    b.ToTable("AreaEmpresa");
                });

            modelBuilder.Entity("Stage.API.DAL.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PK_Empresa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Stage.API.DAL.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PK_Area")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Stage.API.DAL.Models.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PK_Area")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("PK_Empresa")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ProcessoPaiId")
                        .HasColumnType("int");

                    b.Property<int>("TipoProcesso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("PK_Area");

                    b.HasIndex("PK_Empresa");

                    b.HasIndex("ProcessoPaiId");

                    b.ToTable("Processo");
                });

            modelBuilder.Entity("AreaEmpresa", b =>
                {
                    b.HasOne("Stage.API.DAL.Models.Empresa", null)
                        .WithMany()
                        .HasForeignKey("PK_Area")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Stage.API.DAL.Models.Area", null)
                        .WithMany()
                        .HasForeignKey("PK_Empresa")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Stage.API.DAL.Models.Processo", b =>
                {
                    b.HasOne("Stage.API.DAL.Models.Empresa", null)
                        .WithMany("Processos")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("Stage.API.DAL.Models.Area", "Area")
                        .WithMany()
                        .HasForeignKey("PK_Area")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Stage.API.DAL.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("PK_Empresa")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Stage.API.DAL.Models.Processo", "ProcessoPai")
                        .WithMany("SubProcessos")
                        .HasForeignKey("ProcessoPaiId");

                    b.Navigation("Area");

                    b.Navigation("Empresa");

                    b.Navigation("ProcessoPai");
                });

            modelBuilder.Entity("Stage.API.DAL.Models.Empresa", b =>
                {
                    b.Navigation("Processos");
                });

            modelBuilder.Entity("Stage.API.DAL.Models.Processo", b =>
                {
                    b.Navigation("SubProcessos");
                });
#pragma warning restore 612, 618
        }
    }
}
