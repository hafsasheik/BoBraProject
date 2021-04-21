﻿// <auto-generated />
using System;
using BoBra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoBra.Migrations
{
    [DbContext(typeof(BoBraContext))]
    partial class BoBraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoBra.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("BoBra.Models.Broker", b =>
                {
                    b.Property<int>("BrokerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Business")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrokerID");

                    b.ToTable("Broker");
                });

            modelBuilder.Entity("BoBra.Models.BrokerLogin", b =>
                {
                    b.Property<int>("MKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MKID");

                    b.ToTable("BrokerLogin");
                });

            modelBuilder.Entity("BoBra.Models.Broker_Property", b =>
                {
                    b.Property<int>("BrokerID")
                        .HasColumnType("int");

                    b.Property<int>("PropertyID")
                        .HasColumnType("int");

                    b.HasKey("BrokerID", "PropertyID");

                    b.HasIndex("PropertyID");

                    b.ToTable("Broker_Property");
                });

            modelBuilder.Entity("BoBra.Models.Interest_Reg", b =>
                {
                    b.Property<int>("InterestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("PropertyID")
                        .HasColumnType("int");

                    b.HasKey("InterestID");

                    b.HasIndex("AccountID");

                    b.ToTable("Interest_Reg");
                });

            modelBuilder.Entity("BoBra.Models.Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuildYear")
                        .HasColumnType("int");

                    b.Property<string>("HouseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlotArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<DateTime>("ViewingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PropertyID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("BoBra.Models.UserLogin", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("BoBra.Models.Broker_Property", b =>
                {
                    b.HasOne("BoBra.Models.Broker", "Broker")
                        .WithMany("Broker_Property")
                        .HasForeignKey("BrokerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoBra.Models.Property", "Property")
                        .WithMany("Broker_Property")
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Broker");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("BoBra.Models.Interest_Reg", b =>
                {
                    b.HasOne("BoBra.Models.Account", null)
                        .WithMany("Interest_Reg")
                        .HasForeignKey("AccountID");
                });

            modelBuilder.Entity("BoBra.Models.Account", b =>
                {
                    b.Navigation("Interest_Reg");
                });

            modelBuilder.Entity("BoBra.Models.Broker", b =>
                {
                    b.Navigation("Broker_Property");
                });

            modelBuilder.Entity("BoBra.Models.Property", b =>
                {
                    b.Navigation("Broker_Property");
                });
#pragma warning restore 612, 618
        }
    }
}
