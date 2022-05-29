﻿// <auto-generated />
using API_CaseV1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_CaseV1.Migrations
{
    [DbContext(typeof(DBInteractor))]
    [Migration("20220529162003_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("API_CaseV1.Adressen", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Huisnummer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Land")
                        .HasColumnType("TEXT");

                    b.Property<string>("Plaats")
                        .HasColumnType("TEXT");

                    b.Property<string>("Postcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Straat")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Adressen");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Huisnummer = 20,
                            Land = "Nederland",
                            Plaats = "Purmerend",
                            Postcode = "1446BE",
                            Straat = "binnendijk"
                        },
                        new
                        {
                            Id = 2L,
                            Huisnummer = 31,
                            Land = "Nederland",
                            Plaats = "Amsterdam",
                            Postcode = "1012PC",
                            Straat = "kalverstraat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
