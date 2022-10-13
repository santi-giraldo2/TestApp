﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApp.Server.Data;

#nullable disable

namespace TestApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221013074136_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestApp.Server.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1234561,
                            Address = "Calle 2",
                            Age = 19,
                            Email = "camilaGonzalez@mail.com",
                            FirstName = "Camila",
                            Gender = "F",
                            LastName = "Gonzalez",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234562,
                            Address = "Calle 3",
                            Age = 33,
                            Email = "juanPerez@mail.com",
                            FirstName = "Juan",
                            Gender = "M",
                            LastName = "Perez",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234563,
                            Address = "Calle 4",
                            Age = 23,
                            Email = "mariaGomez@mail.com",
                            FirstName = "Maria",
                            Gender = "F",
                            LastName = "Gomez",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234564,
                            Address = "Calle 5",
                            Age = 27,
                            Email = "pedroGarcia@mail.com",
                            FirstName = "Pedro",
                            Gender = "M",
                            LastName = "Garcia",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234565,
                            Address = "Calle 6",
                            Age = 31,
                            Email = "sofiaLopez@mail.com",
                            FirstName = "Sofia",
                            Gender = "F",
                            LastName = "Lopez",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234566,
                            Address = "Calle 7",
                            Age = 27,
                            Email = "andresMartinez@mail.com",
                            FirstName = "Andres",
                            Gender = "M",
                            LastName = "Martinez",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234567,
                            Address = "Calle 7",
                            Age = 31,
                            Email = "santiagoRodriguez@mail.com",
                            FirstName = "Santiago",
                            Gender = "M",
                            LastName = "Rodriguez",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234568,
                            Address = "Calle 8",
                            Age = 34,
                            Email = "valentinaHernandez@mail.com",
                            FirstName = "Valentina",
                            Gender = "F",
                            LastName = "Hernandez",
                            Phone = 123456789
                        },
                        new
                        {
                            Id = 1234569,
                            Address = "Calle 9",
                            Age = 28,
                            Email = "sofiaGonzalez@mail.com",
                            FirstName = "Sofia",
                            Gender = "F",
                            LastName = "Gonzalez",
                            Phone = 123456789
                        });
                });

            modelBuilder.Entity("TestApp.Server.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Blanco",
                            Name = "Pantalon",
                            PersonId = 1234561,
                            Total = 1000
                        },
                        new
                        {
                            Id = 2,
                            Description = "Blanco",
                            Name = "Camisa",
                            PersonId = 1234561,
                            Total = 12000
                        },
                        new
                        {
                            Id = 3,
                            Description = "Blanco",
                            Name = "Camisa",
                            PersonId = 1234562,
                            Total = 12000
                        },
                        new
                        {
                            Id = 4,
                            Description = "Blanco",
                            Name = "Camisa",
                            PersonId = 1234562,
                            Total = 12000
                        },
                        new
                        {
                            Id = 5,
                            Description = "Negro",
                            Name = "Pantalon",
                            PersonId = 1234563,
                            Total = 8000
                        },
                        new
                        {
                            Id = 6,
                            Description = "Alto",
                            Name = "Zapatos",
                            PersonId = 1234563,
                            Total = 10000
                        },
                        new
                        {
                            Id = 7,
                            Description = "Blanco",
                            Name = "Camisa",
                            PersonId = 1234564,
                            Total = 18000
                        },
                        new
                        {
                            Id = 8,
                            Description = "Vaquero",
                            Name = "Pantalon",
                            PersonId = 1234564,
                            Total = 16000
                        },
                        new
                        {
                            Id = 9,
                            Description = "Bajo",
                            Name = "Zapatos",
                            PersonId = 1234565,
                            Total = 20000
                        },
                        new
                        {
                            Id = 10,
                            Description = "Plano",
                            Name = "Gorra",
                            PersonId = 1234565,
                            Total = 10000
                        },
                        new
                        {
                            Id = 11,
                            Description = "Azul",
                            Name = "Bufanda",
                            PersonId = 1234566,
                            Total = 4000
                        },
                        new
                        {
                            Id = 12,
                            Description = "Roja",
                            Name = "Bufanda",
                            PersonId = 1234566,
                            Total = 4000
                        },
                        new
                        {
                            Id = 13,
                            Description = "Naranja",
                            Name = "Blusa",
                            PersonId = 1234567,
                            Total = 4000
                        },
                        new
                        {
                            Id = 14,
                            Description = "Azul",
                            Name = "Pantalón",
                            PersonId = 1234567,
                            Total = 4000
                        },
                        new
                        {
                            Id = 15,
                            Description = "Azul",
                            Name = "Chaqueta",
                            PersonId = 1234568,
                            Total = 4000
                        },
                        new
                        {
                            Id = 16,
                            Description = "Azul",
                            Name = "Sandalias",
                            PersonId = 1234568,
                            Total = 4000
                        },
                        new
                        {
                            Id = 17,
                            Description = "Rojo",
                            Name = "Bufanda",
                            PersonId = 1234569,
                            Total = 4000
                        },
                        new
                        {
                            Id = 18,
                            Description = "Verde",
                            Name = "Sandalias",
                            PersonId = 1234569,
                            Total = 4000
                        });
                });

            modelBuilder.Entity("TestApp.Server.Models.Sale", b =>
                {
                    b.HasOne("TestApp.Server.Models.Person", "Person")
                        .WithMany("Sales")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("TestApp.Server.Models.Person", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
