﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto.Data;

#nullable disable

namespace projeto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projeto.Models.LogUtilizador", b =>
                {
                    b.Property<int>("LogUtilizadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogUtilizadorId"));

                    b.Property<bool>("IsLoginSuccess")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LogDataLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LogMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogUtilizadorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UtilizadorId")
                        .HasColumnType("int");

                    b.HasKey("LogUtilizadorId");

                    b.HasIndex("UtilizadorId");

                    b.ToTable("LogUtilizadores");
                });

            modelBuilder.Entity("projeto.Models.LoginModel", b =>
                {
                    b.Property<int>("LoginModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginModelId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginModelId");

                    b.ToTable("LoginModel");
                });

            modelBuilder.Entity("projeto.Models.Utilizador", b =>
                {
                    b.Property<int>("UtilizadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtilizadorId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoConta")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UtilizadorId");

                    b.ToTable("Utilizador");
                });

            modelBuilder.Entity("projeto.Models.VerificationModel", b =>
                {
                    b.Property<int>("VerificationModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VerificationModelId"));

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("VerificationCode")
                        .HasColumnType("int");

                    b.HasKey("VerificationModelId");

                    b.ToTable("VerificationModel");
                });

            modelBuilder.Entity("projeto.Models.LogUtilizador", b =>
                {
                    b.HasOne("projeto.Models.Utilizador", "Utilizador")
                        .WithMany()
                        .HasForeignKey("UtilizadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizador");
                });
#pragma warning restore 612, 618
        }
    }
}
