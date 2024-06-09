﻿// <auto-generated />
using System;
using KolokwiumCF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KolokwiumCF.Migrations
{
    [DbContext(typeof(KoloContext))]
    [Migration("20240609162809_AddedAmountToPayment")]
    partial class AddedAmountToPayment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KolokwiumCF.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClient"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdClient")
                        .HasName("Client_PK");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            IdClient = 1,
                            Email = "test@mail.com",
                            FirstName = "Sample",
                            LastName = "Client",
                            Phone = "123456789"
                        },
                        new
                        {
                            IdClient = 2,
                            Email = "test@mail.com",
                            FirstName = "Jakub",
                            LastName = "Biologist",
                            Phone = "123456789"
                        },
                        new
                        {
                            IdClient = 3,
                            Email = "test@mail.com",
                            FirstName = "Michal",
                            LastName = "Pediatrician",
                            Phone = "123456789"
                        },
                        new
                        {
                            IdClient = 4,
                            Email = "test@mail.com",
                            FirstName = "Sergio",
                            LastName = "Psychiatrist",
                            Phone = "123456789"
                        },
                        new
                        {
                            IdClient = 5,
                            Email = "test@mail.com",
                            FirstName = "Pablo",
                            LastName = "Dentist",
                            Phone = "123456789"
                        },
                        new
                        {
                            IdClient = 6,
                            Email = "test@mail.com",
                            FirstName = "Azucar",
                            LastName = "Cardiologist",
                            Phone = "123456789"
                        });
                });

            modelBuilder.Entity("KolokwiumCF.Models.Discount", b =>
                {
                    b.Property<int>("IdDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDiscount"));

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("IdDiscount")
                        .HasName("Discount_PK");

                    b.HasIndex("IdClient");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            IdDiscount = 1,
                            DateFrom = new DateTime(2024, 6, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(4715),
                            DateTo = new DateTime(2024, 7, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(4763),
                            IdClient = 1,
                            Value = 10
                        },
                        new
                        {
                            IdDiscount = 2,
                            DateFrom = new DateTime(2024, 6, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(4768),
                            DateTo = new DateTime(2024, 7, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(4769),
                            IdClient = 2,
                            Value = 20
                        },
                        new
                        {
                            IdDiscount = 3,
                            DateFrom = new DateTime(2024, 6, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(4771),
                            DateTo = new DateTime(2024, 7, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(4772),
                            IdClient = 3,
                            Value = 30
                        });
                });

            modelBuilder.Entity("KolokwiumCF.Models.Payment", b =>
                {
                    b.Property<int>("IdPayment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPayment"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdSubscription")
                        .HasColumnType("int");

                    b.HasKey("IdPayment")
                        .HasName("Payment_PK");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdSubscription");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            IdPayment = 1,
                            Amount = 100,
                            Date = new DateTime(2024, 6, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(8830),
                            IdClient = 1,
                            IdSubscription = 1
                        },
                        new
                        {
                            IdPayment = 2,
                            Amount = 200,
                            Date = new DateTime(2024, 6, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(8849),
                            IdClient = 2,
                            IdSubscription = 2
                        },
                        new
                        {
                            IdPayment = 3,
                            Amount = 300,
                            Date = new DateTime(2024, 6, 9, 18, 28, 9, 617, DateTimeKind.Local).AddTicks(8851),
                            IdClient = 3,
                            IdSubscription = 3
                        });
                });

            modelBuilder.Entity("KolokwiumCF.Models.Sale", b =>
                {
                    b.Property<int>("IdSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSale"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdSubscription")
                        .HasColumnType("int");

                    b.HasKey("IdSale")
                        .HasName("IdSale_PK");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdSubscription");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            IdSale = 1,
                            CreatedAt = new DateTime(2024, 6, 9, 18, 28, 9, 618, DateTimeKind.Local).AddTicks(5089),
                            IdClient = 1,
                            IdSubscription = 1
                        },
                        new
                        {
                            IdSale = 2,
                            CreatedAt = new DateTime(2024, 6, 9, 18, 28, 9, 618, DateTimeKind.Local).AddTicks(5117),
                            IdClient = 2,
                            IdSubscription = 2
                        },
                        new
                        {
                            IdSale = 3,
                            CreatedAt = new DateTime(2024, 6, 9, 18, 28, 9, 618, DateTimeKind.Local).AddTicks(5119),
                            IdClient = 3,
                            IdSubscription = 3
                        });
                });

            modelBuilder.Entity("KolokwiumCF.Models.Subscription", b =>
                {
                    b.Property<int>("IdSubscription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSubscription"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RenewalPeriod")
                        .HasColumnType("int");

                    b.HasKey("IdSubscription")
                        .HasName("Subscription_PK");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            IdSubscription = 1,
                            EndTime = new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Sample",
                            Price = 100.0,
                            RenewalPeriod = 5
                        },
                        new
                        {
                            IdSubscription = 2,
                            EndTime = new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Jakub",
                            Price = 200.0,
                            RenewalPeriod = 10
                        },
                        new
                        {
                            IdSubscription = 3,
                            EndTime = new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Michal",
                            Price = 300.0,
                            RenewalPeriod = 15
                        });
                });

            modelBuilder.Entity("KolokwiumCF.Models.Discount", b =>
                {
                    b.HasOne("KolokwiumCF.Models.Client", "IdClientNav")
                        .WithMany("Discounts")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Client_Discount_FK");

                    b.Navigation("IdClientNav");
                });

            modelBuilder.Entity("KolokwiumCF.Models.Payment", b =>
                {
                    b.HasOne("KolokwiumCF.Models.Client", "IdClientNav")
                        .WithMany("Payments")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Payment_Client_FK");

                    b.HasOne("KolokwiumCF.Models.Subscription", "IdSubscriptionNav")
                        .WithMany("Payments")
                        .HasForeignKey("IdSubscription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Subscription_Payment_FK");

                    b.Navigation("IdClientNav");

                    b.Navigation("IdSubscriptionNav");
                });

            modelBuilder.Entity("KolokwiumCF.Models.Sale", b =>
                {
                    b.HasOne("KolokwiumCF.Models.Client", "IdClientNav")
                        .WithMany("Sales")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Client_Sale_FK");

                    b.HasOne("KolokwiumCF.Models.Subscription", "IdSubscriptionNav")
                        .WithMany("Sales")
                        .HasForeignKey("IdSubscription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Subscription_Sale_FK");

                    b.Navigation("IdClientNav");

                    b.Navigation("IdSubscriptionNav");
                });

            modelBuilder.Entity("KolokwiumCF.Models.Client", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("Payments");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("KolokwiumCF.Models.Subscription", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
