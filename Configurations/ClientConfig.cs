using KolokwiumCF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumCF.Configurations;

public class ClientConfig : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.IdClient)
            .HasName("Client_PK");

        builder.Property(c => c.IdClient)
            .UseIdentityColumn();

        builder.Property(c => c.FirstName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(c => c.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(c => c.Email)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(c => c.Phone)
            .HasMaxLength(100);

        builder.HasMany(c => c.Payments)
            .WithOne(p => p.IdClientNav)
            .HasForeignKey(p => p.IdClient)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("Payment_Client_FK");

        builder.HasMany(c => c.Discounts)
            .WithOne(d => d.IdClientNav)
            .HasForeignKey(d => d.IdClient)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("Client_Discount_FK");

        builder.HasMany(c => c.Sales)
            .WithOne(s => s.IdClientNav)
            .HasForeignKey(s => s.IdClient)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("Client_Sale_FK");

        var clients = new List<Client>
        {
            new()
            {
                IdClient = 1,
                FirstName = "Bananowy",
                LastName = "Samuraj",
                Email = "bananowy@mail.com",
                Phone = "987654321"
            },
            new()
            {
                IdClient = 2,
                FirstName = "Gruby",
                LastName = "Kotleciarz",
                Email = "kotleciarz@mail.com",
                Phone = "987654322"
            },
            new()
            {
                IdClient = 3,
                FirstName = "Hipster",
                LastName = "Bekon",
                Email = "bekon@mail.com",
                Phone = "987654323"
            },
            new()
            {
                IdClient = 4,
                FirstName = "Ziom",
                LastName = "Kartofel",
                Email = "kartofel@mail.com",
                Phone = "987654324"
            },
            new()
            {
                IdClient = 5,
                FirstName = "Szybki",
                LastName = "Joe",
                Email = "szybkijoe@mail.com",
                Phone = "987654325"
            },
            new()
            {
                IdClient = 6,
                FirstName = "Wesoły",
                LastName = "Ogórek",
                Email = "wogorek@mail.com",
                Phone = "987654326"
            },
            new()
            {
                IdClient = 7,
                FirstName = "Kłapuch",
                LastName = "Okrągły",
                Email = "klapouchyo@mail.com",
                Phone = "987654326"
            }
        };

        builder.HasData(clients);
    }
}