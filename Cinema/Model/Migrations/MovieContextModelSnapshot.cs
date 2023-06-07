﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Configurations;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ADDRESS_ID");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("COUNTRY");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("LOCATION");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT")
                        .HasColumnName("POSTAL_CODE");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("STATE");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("STREET");

                    b.HasKey("Id");

                    b.HasIndex("CountryName");

                    b.HasIndex("StateCode");

                    b.ToTable("ADDRESSES");
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("NAME");

                    b.HasKey("Name");

                    b.ToTable("E_COUNTRIES");
                });

            modelBuilder.Entity("Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("HALL_ID");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CAPACITY");

                    b.Property<int>("CinemaId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CINEMA_ID");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("TEXT")
                        .HasColumnName("CODE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("TEXT")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("HALLS");
                });

            modelBuilder.Entity("Model.Entities.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("CINEMA_ID");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ADDRESS_ID");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("LABEL");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("CINEMAS");
                });

            modelBuilder.Entity("Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("MOVIE_ID");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("DIRECTOR");

                    b.Property<int>("Length")
                        .HasMaxLength(900)
                        .HasColumnType("INTEGER")
                        .HasColumnName("LENGTH");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("TEXT")
                        .HasColumnName("SHORT_DESCRIPTION");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.ToTable("MOVIES");
                });

            modelBuilder.Entity("Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("PERSON_ID");

                    b.Property<string>("DISCRIMINATOR")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("TEXT")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("TEXT")
                        .HasColumnName("LAST_NAME");

                    b.HasKey("Id");

                    b.ToTable("PERSONS");

                    b.HasDiscriminator<string>("DISCRIMINATOR").HasValue("Person");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("NAME");

                    b.HasKey("Name");

                    b.ToTable("E_STATES");
                });

            modelBuilder.Entity("Model.Entities.Crew", b =>
                {
                    b.HasBaseType("Person");

                    b.ToTable("PERSONS");

                    b.HasDiscriminator().HasValue("CREW");
                });

            modelBuilder.Entity("Model.Entities.Customer", b =>
                {
                    b.HasBaseType("Person");

                    b.ToTable("PERSONS");

                    b.HasDiscriminator().HasValue("CUSTOMER");
                });

            modelBuilder.Entity("Model.Entities.DocumentaryMovie", b =>
                {
                    b.HasBaseType("Movie");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("TOPIC");

                    b.ToTable("DOCU_MOVIES", (string)null);
                });

            modelBuilder.Entity("Model.Entities.EntertainmentMovie", b =>
                {
                    b.HasBaseType("Movie");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CATEGORY");

                    b.ToTable("ENTERTAINMENT_MOVIES", (string)null);
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.HasOne("Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("State", "State")
                        .WithMany()
                        .HasForeignKey("StateCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Hall", b =>
                {
                    b.HasOne("Model.Entities.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("Model.Entities.Cinema", b =>
                {
                    b.HasOne("Address", "Address")
                        .WithOne()
                        .HasForeignKey("Model.Entities.Cinema", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Model.Entities.DocumentaryMovie", b =>
                {
                    b.HasOne("Movie", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.DocumentaryMovie", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.EntertainmentMovie", b =>
                {
                    b.HasOne("Movie", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.EntertainmentMovie", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
