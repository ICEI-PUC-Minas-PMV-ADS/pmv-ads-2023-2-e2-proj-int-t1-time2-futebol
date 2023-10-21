﻿// <auto-generated />
using FutScout_2023.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FutScout_2023.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FutScout_2023.Models.Atacante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Assists2021")
                        .HasColumnType("int");

                    b.Property<int>("Assists2022")
                        .HasColumnType("int");

                    b.Property<int>("Assists2023")
                        .HasColumnType("int");

                    b.Property<string>("Clube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gols2021")
                        .HasColumnType("int");

                    b.Property<int>("Gols2022")
                        .HasColumnType("int");

                    b.Property<int>("Gols2023")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Partidas2021")
                        .HasColumnType("int");

                    b.Property<int>("Partidas2022")
                        .HasColumnType("int");

                    b.Property<int>("Partidas2023")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Atacantes");
                });

            modelBuilder.Entity("FutScout_2023.Models.Clube", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Série")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gols2021")
                        .HasColumnType("int");

                    b.Property<int>("gols2022")
                        .HasColumnType("int");

                    b.Property<int>("gols2023")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clubes");
                });

            modelBuilder.Entity("FutScout_2023.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuários");
                });
#pragma warning restore 612, 618
        }
    }
}