﻿// <auto-generated />
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HairSalon.Migrations
{
    [DbContext(typeof(HairSalonContext))]
    partial class HairSalonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HairSalon.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApptDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Services");

                    b.Property<int>("StylistId");

                    b.HasKey("Id");

                    b.HasIndex("StylistId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("HairSalon.Models.Stylist", b =>
                {
                    b.Property<int>("StylistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Specialty");

                    b.HasKey("StylistId");

                    b.ToTable("Stylists");
                });

            modelBuilder.Entity("HairSalon.Models.Client", b =>
                {
                    b.HasOne("HairSalon.Models.Stylist", "Stylist")
                        .WithMany("Clients")
                        .HasForeignKey("StylistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}