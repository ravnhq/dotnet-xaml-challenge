using System;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Data.Configuration;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
  public void Configure(EntityTypeBuilder<Ticket> builder)
  {

    builder.Property(t => t.Subject).IsRequired().HasMaxLength(200);
    builder.Property(t => t.Status)
    .IsRequired()
    .HasConversion<EnumToStringConverter<TicketStatus>>();

    builder.Property(t => t.CreatedAt).IsRequired();

    builder.Property(x => x.CreatedAt).HasDefaultValueSql("current_timestamp");

    builder.OwnsMany(x => x.ExternalResources);

    builder.HasOne(x => x.Customer)
    .WithMany()
    .HasForeignKey(x => x.CustomerId);
  }
}

