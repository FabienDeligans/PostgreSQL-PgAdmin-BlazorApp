﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgreSQLBlazorApp.Data;

namespace PostgreSQLBlazorApp.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PostgreSQLBlazorApp.Models.Enfant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("FamilleId")
                        .HasColumnType("integer");

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FamilleId");

                    b.ToTable("Enfant");
                });

            modelBuilder.Entity("PostgreSQLBlazorApp.Models.Famille", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NomDeFamille")
                        .HasColumnType("text");

                    b.Property<int>("Qf")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Famille");
                });

            modelBuilder.Entity("PostgreSQLBlazorApp.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("text");

                    b.Property<string>("Cp")
                        .HasColumnType("text");

                    b.Property<int>("FamilleId")
                        .HasColumnType("integer");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .HasColumnType("text");

                    b.Property<string>("Tel")
                        .HasColumnType("text");

                    b.Property<string>("Ville")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FamilleId");

                    b.ToTable("Parent");
                });

            modelBuilder.Entity("PostgreSQLBlazorApp.Models.Enfant", b =>
                {
                    b.HasOne("PostgreSQLBlazorApp.Models.Famille", "Famille")
                        .WithMany("Enfants")
                        .HasForeignKey("FamilleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostgreSQLBlazorApp.Models.Parent", b =>
                {
                    b.HasOne("PostgreSQLBlazorApp.Models.Famille", "Famille")
                        .WithMany("Parents")
                        .HasForeignKey("FamilleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}