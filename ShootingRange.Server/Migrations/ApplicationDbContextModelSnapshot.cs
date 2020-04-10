﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShootingRange.Server.Data;

namespace ShootingRange.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShootingRange.Core.DomainModels.Contact", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Techno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });
<<<<<<< HEAD

            modelBuilder.Entity("ShootingRange.Core.DomainModels.Lokalizacja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lokalizacja");
                });

            modelBuilder.Entity("ShootingRange.Core.DomainModels.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CenaZaH")
                        .HasColumnType("real");

                    b.Property<bool>("GodzinyDoby")
                        .HasColumnType("bit");

                    b.Property<int>("IloscGodzinDob")
                        .HasColumnType("int");

                    b.Property<float>("Poczatek")
                        .HasColumnType("real");

                    b.Property<int>("SamochodId")
                        .HasColumnType("int");

                    b.Property<bool>("Wykupiona")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Oferta");
                });

            modelBuilder.Entity("ShootingRange.Core.DomainModels.Samochod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LokalizacjaId")
                        .HasColumnType("int");

                    b.Property<int?>("OfertaId")
                        .HasColumnType("int");

                    b.Property<int>("UzytkownikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LokalizacjaId");

                    b.HasIndex("OfertaId");

                    b.HasIndex("UzytkownikId");

                    b.ToTable("Samochod");
                });

            modelBuilder.Entity("ShootingRange.Core.DomainModels.Uzytkownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Haslo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrTelefonu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("StanKonta")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Uzytkownik");
                });

            modelBuilder.Entity("ShootingRange.Core.DomainModels.Samochod", b =>
                {
                    b.HasOne("ShootingRange.Core.DomainModels.Lokalizacja", "Lokalizacja")
                        .WithMany("ListaSamochodow")
                        .HasForeignKey("LokalizacjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShootingRange.Core.DomainModels.Oferta", null)
                        .WithMany("ListaSamochodow")
                        .HasForeignKey("OfertaId");

                    b.HasOne("ShootingRange.Core.DomainModels.Uzytkownik", "Uzytkownik")
                        .WithMany("ListaSamochodow")
                        .HasForeignKey("UzytkownikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
=======
>>>>>>> 22b4480249bd0ad61ca7e936bb48b9a1e2c5bd6c
#pragma warning restore 612, 618
        }
    }
}
